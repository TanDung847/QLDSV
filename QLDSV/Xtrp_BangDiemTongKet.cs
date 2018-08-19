using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.XtraEditors.Controls;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data;

namespace QLDSV
{
    public partial class Xtrp_BangDiemTongKet : DevExpress.XtraReports.UI.XtraReport
    {
        public Xtrp_BangDiemTongKet(String malop, String tenlop)
        {
            InitializeComponent();
            this.lbLop.Text = "Lớp: " + tenlop;
            // Create a detail report band and bind it to data.
            DetailReportBand detailReportBand = new DetailReportBand();
            this.Bands.Add(detailReportBand);

            // Add a header to the detail report.
            ReportHeaderBand detailReportHeader = new ReportHeaderBand();
            detailReportBand.Bands.Add(detailReportHeader);

            XRTable tableHeader = new XRTable();
            tableHeader.BeginInit();
            tableHeader.Rows.Add(new XRTableRow());
            tableHeader.Borders = DevExpress.XtraPrinting.BorderSide.All;
            tableHeader.BorderColor = Color.DarkGray;
            tableHeader.Font = new Font("Tahoma", 10, System.Drawing.FontStyle.Bold);
            tableHeader.Padding = 10;
            tableHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;

            String cmd = "EXEC sp_BANGDIEMTONGKET '" + malop + "'";
            SqlDataReader reader = Program.ExecSqlDataReader(cmd);
            if (reader != null && reader.HasRows)
            {
                tableHeader.Rows.Add(new XRTableRow());
                List<XRTableCell> titleCells = new List<XRTableCell>();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    XRTableCell cell = new XRTableCell();
                    cell.Text = reader.GetName(i);
                    titleCells.Add(cell);
                }
                tableHeader.Rows[0].Cells.AddRange(titleCells.ToArray());

                DataTable dt = new DataTable();
                dt.Load(reader);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    tableHeader.Rows.Add(new XRTableRow());
                    List<XRTableCell> dataCells = new List<XRTableCell>();
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        XRTableCell cell = new XRTableCell();
                        cell.Text = dt.Rows[i][j].ToString();
                        cell.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
                        dataCells.Add(cell);
                    }
                    tableHeader.Rows[i + 1].Cells.AddRange(dataCells.ToArray());
                }
            }

            
            detailReportHeader.Height = tableHeader.Height;
            detailReportHeader.Controls.Add(tableHeader);

            // Adjust the table width.
            tableHeader.BeforePrint += tableHeader_BeforePrint;
            tableHeader.EndInit();

        }
        private void AdjustTableWidth(XRTable table)
        {
            XtraReport report = table.RootReport;
            table.WidthF = report.PageWidth - report.Margins.Left - report.Margins.Right;
        }

        void tableHeader_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            AdjustTableWidth(sender as XRTable);
        }

        void tableDetail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            AdjustTableWidth(sender as XRTable);
        }

    }

}
