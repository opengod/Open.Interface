using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using OfficeOpenXml;
using OfficeOpenXml.Drawing;
using OfficeOpenXml.Style;
using QRCoder;
using Open.Utils.Helper;
using static QRCoder.QRCodeGenerator;

namespace Open.Utils.Excel
{
    /// <summary>
    /// Excel导入导出助手
    /// NuGet：EPPlus.Core
    /// </summary>
    public sealed class ExcelEpPlus
    {

        private ExcelEpPlus()
        {

        }

        /// <summary>
        /// Excel文件 Content-Type
        /// </summary>
        private const string Excel = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";

        /// <summary>
        /// Excel导出
        /// </summary>
        /// <param name="keyValuePairs">字典表【名称，数据】</param>
        /// <param name="sWebRootFolder">网站根文件夹</param>
        /// <param name="tuple">item1:The virtual path of the file to be returned.|item2:The Content-Type of the file</param>
        /// <param name="isExportAddQRCode">如果实体中有二维码，是否导出二维码</param>
        public static void Export<T>(string worksheetTitle, List<T> list, string sWebRootFolder, out Tuple<string, string> tuple, bool isExportAddQRCode) where T : new()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(sWebRootFolder))
                    tuple = Tuple.Create("", Excel);

                string sFileName = $"{DateTime.Now.ToString("yyyyMMddHHmmssfff")}.xlsx";
                var savePath = Path.Combine(sWebRootFolder, sFileName);
                if (!Directory.Exists(Path.GetDirectoryName(savePath)))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(savePath));
                }
                FileInfo file = new FileInfo(Path.Combine(sWebRootFolder, sFileName));
                using (ExcelPackage package = new ExcelPackage(file))
                {

                    // 添加worksheet
                    ExcelWorksheet worksheet = package.Workbook.Worksheets.Add(worksheetTitle);
                    var jColumns = 0;

                    for (int i = 0; i < list.Count; i++)
                    {
                        var propertyList = Reflection.GetProperties(list[i]);

                        for (int j = 0; j < propertyList.Count; j++)
                        {
                            if (i == 0)
                            {
                                if (!isExportAddQRCode && propertyList[j].Description == "二维码")
                                {
                                    continue;
                                }
                                worksheet.Cells[1, j + 1].Value = propertyList[j].Description;
                                worksheet.Cells[1, j + 1].Style.Font.Bold = true;//字体为粗体
                                worksheet.Cells[1, j + 1].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;//水平居中
                                worksheet.Cells[1, j + 1].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;//设置样式类型
                                worksheet.Cells[1, j + 1].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.FromArgb(159, 197, 232));//设置单元格背景色
                            }

                            if (propertyList[j].Description == "二维码")
                            {

                                if (!isExportAddQRCode) continue;

                                #region 生成二维码并添加到Excel
                                //string value = propertyList[j].Value == null ? null: propertyList[j].Value.ToString();
                                //if (!string.IsNullOrWhiteSpace(value))
                                //{
                                //    using (QRCodeGenerator qrGenerator = new QRCoder.QRCodeGenerator())
                                //    {
                                //        //QRCodeGenerator.ECCLevel:纠错能力,Q级：约可纠错25%的数据码字
                                //        var img = ImageHelper.CreateQrCode(value, ECCLevel.Q, 2);

                                //        using (MemoryStream stream = new MemoryStream())
                                //        {
                                //            img.Save(stream, ImageFormat.Jpeg);
                                //            byte[] bytes = new byte[stream.Length];
                                //            stream.Seek(0, SeekOrigin.Begin);
                                //            stream.Read(bytes, 0, System.Convert.ToInt32(stream.Length));

                                //            using (MemoryStream ms = new MemoryStream(bytes))
                                //            {
                                //                System.Drawing.Bitmap myimge = new System.Drawing.Bitmap(ms);
                                //                ExcelPicture picture = worksheet.Drawings.AddPicture(Common.GuId(), myimge);//插入图片
                                //                worksheet.Row(i + 2).Height = 80.00D;
                                //                picture.SetPosition(i + 1, 5, 24, 5);//设置图片的位置
                                //                picture.SetSize(80, 80);//设置图片的大小
                                //            }
                                //        }
                                //    }
                                //}
                                #endregion

                                //worksheet.Cells[i + 2, j + 1].Value = "";
                                byte[] bytes = propertyList[j].Value == null ? new byte[0] : (byte[])propertyList[j].Value;

                                if (bytes.Length > 0)
                                {
                                    using (MemoryStream ms = new MemoryStream(bytes))
                                    {
                                        System.Drawing.Bitmap myimge = new System.Drawing.Bitmap(ms);
                                        ExcelPicture picture = worksheet.Drawings.AddPicture(Common.GuId(), myimge);//插入图片
                                        worksheet.Row(i + 2).Height = 80.00D;
                                        picture.SetPosition(i + 1, 5, 24, 5);//设置图片的位置
                                        picture.SetSize(80, 80);//设置图片的大小
                                    }
                                }
                                jColumns = j + 1;
                            }
                            else
                            {
                                //添加值
                                worksheet.Cells[i + 2, j + 1].Value = propertyList[j].Value == null
                                    ? ""
                                    : (propertyList[j].Value.ToString() == "0001/1/1 0:00:00" ? "" : propertyList[j].Value.ToString());
                            }
                            worksheet.Cells[i + 2, j + 1].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;//水平居中
                            worksheet.Cells[i + 2, j + 1].Style.VerticalAlignment = ExcelVerticalAlignment.Center;//垂直居中
                        }
                    }

                    if (jColumns == 0)
                    {
                        //自动列宽
                        worksheet.Cells.AutoFitColumns();
                    }
                    else
                    {
                        //自动列宽
                        worksheet.Cells.AutoFitColumns();
                        worksheet.Column(jColumns).Width = 20.00D;//设置列宽
                    }
                    package.Save();
                }
                tuple = Tuple.Create(sFileName, Excel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }


        /// <summary>
        /// Excel导出
        /// </summary>
        /// <param name="keyValuePairs">字典表【名称，数据】</param>
        /// <param name="sWebRootFolder">网站根文件夹</param>
        /// <param name="tuple">item1:The virtual path of the file to be returned.|item2:The Content-Type of the file</param>
        public static void Export(Dictionary<string, DataTable> keyValuePairs, string sWebRootFolder, out Tuple<string, string> tuple)
        {
            if (string.IsNullOrWhiteSpace(sWebRootFolder))
                tuple = Tuple.Create("", Excel);

            string sFileName = $"{DateTime.Now.ToString("yyyyMMddHHmmssfff")}.xlsx";
            var savePath = Path.Combine(sWebRootFolder, sFileName);
            if (!Directory.Exists(Path.GetDirectoryName(savePath)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(savePath));
            }
            FileInfo file = new FileInfo(Path.Combine(sWebRootFolder, sFileName));
            using (ExcelPackage package = new ExcelPackage(file))
            {
                foreach (var item in keyValuePairs)
                {
                    string worksheetTitle = item.Key; //表名称
                    var dt = item.Value; //数据表

                    // 添加worksheet
                    ExcelWorksheet worksheet = package.Workbook.Worksheets.Add(worksheetTitle);
                    var jColumns = 0;
                    for (int i = 0; i <dt.Rows.Count; i++)
                    {
                        for (int j = 0; j <dt.Columns.Count; j++)
                        {
                            if (i == 0)
                            {
                                //添加表头
                                worksheet.Cells[1, j + 1].Value = dt.Columns[j].ColumnName;
                                worksheet.Cells[1, j + 1].Style.Font.Bold = true;//字体为粗体
                                worksheet.Cells[1, j + 1].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;//水平居中
                                worksheet.Cells[1, j + 1].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;//设置样式类型
                                worksheet.Cells[1, j + 1].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.FromArgb(159, 197, 232));//设置单元格背景色
                            }
                            else
                            {
                                if (dt.Columns[j].ColumnName == "二维码")
                                {
                                    if (!string.IsNullOrEmpty(dt.Rows[i][j].ToString()))
                                    {
                                        using (QRCodeGenerator qrGenerator = new QRCoder.QRCodeGenerator())
                                        {
                                            //QRCodeGenerator.ECCLevel:纠错能力,Q级：约可纠错25%的数据码字
                                            QRCodeData qrCodeData = qrGenerator.CreateQrCode(dt.Rows[i][j].ToString(), QRCodeGenerator.ECCLevel.Q);
                                            QRCode qrcode = new QRCode(qrCodeData);
                                            Bitmap qrCodeImage = qrcode.GetGraphic(15);

                                            using (MemoryStream stream = new MemoryStream())
                                            {
                                                qrCodeImage.Save(stream, ImageFormat.Jpeg);
                                                byte[] bytes = new byte[stream.Length];
                                                stream.Seek(0, SeekOrigin.Begin);
                                                stream.Read(bytes, 0, System.Convert.ToInt32(stream.Length));

                                                System.IO.MemoryStream ms = new System.IO.MemoryStream(bytes);
                                                System.Drawing.Bitmap myimge = new System.Drawing.Bitmap(ms);

                                                ExcelPicture picture = worksheet.Drawings.AddPicture(Common.GuId(), myimge);//插入图片
                                                worksheet.Row(i + 1).Height = 80.00D;
                                                picture.SetPosition(i, 5, 24, 5);//设置图片的位置
                                                picture.SetSize(80, 80);//设置图片的大小
                                            }
                                        }
                                    }
                                    jColumns = j + 1;

                                }
                                else
                                {
                                    //添加值
                                    worksheet.Cells[i + 1, j + 1].Value = dt.Rows[i][j].ToString();

                                }
                                worksheet.Cells[i + 1, j + 1].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;//水平居中
                                worksheet.Cells[i + 1, j + 1].Style.VerticalAlignment = ExcelVerticalAlignment.Center;//垂直居中
                                //worksheet.Row(i+1).Height = 85;//设置行高
                            }
                        }
                    }

                    if(jColumns==0)
                    {
                        //自动列宽
                        worksheet.Cells.AutoFitColumns();
                    }
                    else
                    {
                        //自动列宽
                        worksheet.Cells.AutoFitColumns();
                        worksheet.Column(jColumns).Width =20.00D;//设置列宽
                    }
                    
                }


                package.Save();
            }
            tuple = Tuple.Create(sFileName, Excel);
        }

        /// <summary>
        /// Excel导出
        /// </summary>
        /// <param name="keyValuePairs">字典表【名称，数据】</param>
        /// <param name="sWebRootFolder">网站根文件夹</param>
        /// <param name="sFileName">文件名(不要包含后缀.xlsx)</param>
        /// <param name="title">第一行标题</param>
        /// <param name="titleIndex">第一行标题的合并到第几列</param>
        /// <param name="tuple">item1:The virtual path of the file to be returned.|item2:The Content-Type of the file</param>
        public static void Export(Dictionary<string, DataTable> keyValuePairs, string sWebRootFolder, string sFileName, string title, string titleIndex, out Tuple<string, string> tuple, double columnsWidth = 0)
        {
            if (string.IsNullOrWhiteSpace(sWebRootFolder))
                tuple = Tuple.Create("", Excel);

            sFileName = $"{sFileName}.{DateTime.Now.ToString("yyyyMMddHHmmssfff")}.xlsx";
            var savePath = Path.Combine(sWebRootFolder, sFileName);
            if (!Directory.Exists(Path.GetDirectoryName(savePath)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(savePath));
            }
            FileInfo file = new FileInfo(Path.Combine(sWebRootFolder, sFileName));
            using (ExcelPackage package = new ExcelPackage(file))
            {
                foreach (var item in keyValuePairs)
                {
                    var rowIndex = 0;
                    var dt = item.Value;
                    var worksheet = package.Workbook.Worksheets.Add(item.Key);

                    //添加标题
                    rowIndex = 1;
                    var cell = worksheet.Cells[$"A1:{titleIndex}1"];
                    cell.Merge = true;
                    cell.Value = title;
                    cell.Style.Font.Bold = true;//字体为粗体
                    cell.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;//水平居中
                    cell.Style.Fill.PatternType = ExcelFillStyle.Solid;//设置样式类型
                    cell.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(159, 197, 232));//设置单元格背景色
                    cell.Style.Border.BorderAround(ExcelBorderStyle.Thin, Color.FromArgb(0, 0, 0));//单元格边框

                    //添加表头
                    rowIndex = 2;
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        cell = worksheet.Cells[rowIndex, j + 1];
                        cell.Value = dt.Columns[j].ColumnName;
                        cell.Style.Font.Bold = true;//字体为粗体
                        cell.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;//水平居中
                        cell.Style.Fill.PatternType = ExcelFillStyle.Solid;//设置样式类型
                        cell.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(159, 197, 232));//设置单元格背景色                                                                                            
                        cell.Style.Border.BorderAround(ExcelBorderStyle.Thin, Color.FromArgb(0, 0, 0));//单元格边框
                    }

                    //添加表值
                    rowIndex = 3;
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            cell = worksheet.Cells[rowIndex, j + 1];
                            cell.Value = dt.Rows[i][j].ToString();
                            cell.Style.Border.BorderAround(ExcelBorderStyle.Thin, Color.FromArgb(0, 0, 0));//单元格边框
                            cell.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;//水平居中
                            cell.Style.VerticalAlignment = ExcelVerticalAlignment.Center;//垂直居中
                        }

                        rowIndex++;
                    }

                    //自动列宽
                    worksheet.Cells.AutoFitColumns();
                    if (columnsWidth != 0) worksheet.Column(1).Width = columnsWidth;//注意：设置第一列的宽度
                    worksheet.Cells.Style.WrapText = true;
                }

                package.Save();
            }
            tuple = Tuple.Create(sFileName, Excel);
        }

        /// <summary>
        /// Excel导入
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="request">导入文件</param>
        /// <param name="colNames">excel列名-对象属性</param>
        /// <returns></returns>
        public static List<T> ImportByEPPlus<T>(string fileUrl, string[] colNames)
        {
            try
            {
                Dictionary<string, int> dictHeader = new Dictionary<string, int>();
                FileInfo existingFile = new FileInfo(fileUrl);
                List<T> InfoList = new List<T>();
                using (ExcelPackage package = new ExcelPackage(existingFile))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                    int colStart = worksheet.Dimension.Start.Column;  //工作区开始列
                    int colEnd = worksheet.Dimension.End.Column;       //工作区结束列
                    int rowStart = worksheet.Dimension.Start.Row;       //工作区开始行号
                    int rowEnd = worksheet.Dimension.End.Row;       //工作区结束行号
                    #region 格式检查
                    List<string> listHeader = new List<string>();
                    for (int i = colStart; i <= colEnd; i++)
                    {
                        if (!worksheet.Cells[rowStart, i].Value.IsEmpty())
                        {
                            listHeader.Add(worksheet.Cells[rowStart, i].Value.ToString());
                        }
                    }
                    bool isChecked = true;
                    foreach (var strColName in colNames)
                    {
                        string[] handArray = strColName.Split('-');
                        if (!listHeader.Any(p => p == handArray[0]))
                        {
                            isChecked = false;
                            break;
                        }
                    }
                    #endregion
                    if (!isChecked)
                    {
                        throw new Exception("导入的Excel文件格式错误，缺少某些列");
                    }
                    else
                    {
                        for (int i = colStart; i <= colEnd; i++)
                        {
                            if (!worksheet.Cells[rowStart, i].Value.IsEmpty())
                            {
                                dictHeader[worksheet.Cells[rowStart, i].Value.ToString()] = i;
                            }
                        }
                        string val = string.Empty;
                        for (int row = rowStart + 1; row <= rowEnd; row++)
                        {
                            T t = Activator.CreateInstance<T>();
                            foreach (string str in colNames)
                            {
                                string[] array = str.Split('-');
                                ExcelRange cell = worksheet.Cells[row, dictHeader[array[0]]];
                                val = cell.Value?.ToString().Trim();

                                PropertyInfo[] TpropertyInfo = typeof(T).GetProperties();
                                foreach (PropertyInfo p in TpropertyInfo)
                                {
                                    if (p.Name.ToLower() == array[1].ToLower())
                                    {
                                        p.SetValue(t, val, null);
                                    }
                                }
                            }
                            InfoList.Add(t);
                        }
                    }
                    return InfoList;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
