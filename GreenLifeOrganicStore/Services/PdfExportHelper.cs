using GreenLifeOrganicStore.Services;
using iText.Kernel.Pdf;
using iText.Layout.Element;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.Layout;


namespace GreenLifeOrganicStore.Services
{
    public class PdfExportHelper
    {
        // Export DataGridView data to PDF file
        public void ExportDataGridViewToPdf(DataGridView dgv, string filePath, string reportTitle)
        {
            // Check whether grid has rows to export
            if (dgv.Rows.Count == 0)
            {
                throw new Exception("No data available to export.");
            }

            // Create PDF writer and document
            using (PdfWriter writer = new PdfWriter(filePath))
            {
                using (PdfDocument pdf = new PdfDocument(writer))
                {
                    using (Document document = new Document(pdf))
                    {
                        // Add report title
                        Paragraph title = new Paragraph(reportTitle);
                        title.SetFontSize(16);

                        document.Add(title);
                        document.Add(new Paragraph("Generated Date: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")));
                        document.Add(new Paragraph(" ")); // Empty line

                        // Count only visible columns
                        int visibleColumnCount = 0;
                        foreach (DataGridViewColumn column in dgv.Columns)
                        {
                            if (column.Visible)
                            {
                                visibleColumnCount++;
                            }
                        }

                        // Create table with visible column count
                        Table table = new Table(visibleColumnCount);

                        // Add column headers
                        foreach (DataGridViewColumn column in dgv.Columns)
                        {
                            if (column.Visible)
                            {
                                table.AddHeaderCell(column.HeaderText);
                            }
                        }

                        // Add row data
                        foreach (DataGridViewRow row in dgv.Rows)
                        {
                            // Skip the empty new row if present
                            if (row.IsNewRow)
                                continue;

                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                if (cell.Visible)
                                {
                                    string cellValue = cell.Value == null ? "" : cell.Value.ToString();
                                    table.AddCell(cellValue);
                                }
                            }
                        }

                        // Add table to PDF
                        document.Add(table);
                    }
                }
            }
        }
    }
}
