using System;
using System.Drawing;
using System.IO;
using System.Net.Mail;
using System.Reflection;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace TravelyseAddInNM
{
    public partial class ucPlanTravel : UserControl
    {

        Boolean bConfirmBooking = false;

        public ucPlanTravel()
        {
            InitializeComponent();
        }

        private void btnPlanTravel_Click(object sender, EventArgs e)
        {
            if (dgvTravelPlan.SelectedRows.Count != 0)
            {
                DataGridViewRow dr = dgvTravelPlan.SelectedRows[0];
                String strTrip = dr.Cells[0].Value.ToString();

                String strFrom = strTrip.Substring(0, strTrip.IndexOf(" "));
                strFrom = strFrom.Trim() == "LON" ? "LHR" : strFrom;

                String strTo = strTrip.Substring(strTrip.LastIndexOf(' ') + 1);
                strTo = strTo.Trim() == "PUN" ? "PNG" : strTo;

                String strUrl = String.Format("http://104.211.178.94:9001/travel_search?from={0}&to={1}&time_preference=&date_of_travel={2}", strFrom, strTo, "16-05-2018");

                System.Diagnostics.Process.Start(strUrl);
            }
            else
                System.Diagnostics.Process.Start("http://104.211.178.94:9001/");
        }

        private void ucPlanTravel_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            label3.Text = "We will be sending your travel itinerary for booking directly. Please confirm that we have picked your preferences correctly:";
            pnlConfirmBooking.Visible = false;
            dgvItinerary.Rows.Clear();

            dgvTravelPlan.Columns.Add("colTrip", "Trip");
            dgvTravelPlan.Columns.Add("colDate", "Date");
            dgvTravelPlan.Columns.Add("colStatus", "Status");
            dgvTravelPlan.Columns.Add("colEstimatedCost", "Est.Cost");
            dgvTravelPlan.Columns.Add(new DataGridViewButtonColumn() {Text=" ", Name = "btnOneCick", HeaderText = "One Click" });
            

            dgvTravelPlan.Rows.Add("LON - AMS", "11 May - 13 May", "Open", "£380", null);
            dgvTravelPlan.Rows.Add("BLR - LON", "14 May - 17 May", "Approved", "£560", null);
            dgvTravelPlan.Rows.Add("LON - AMS", "18 May - 21 May", "Approved", "£260", ">");
            dgvTravelPlan.Rows.Add("BLR - DAL", "22 May - 24 May", "Submitted", "£1425", null);
            dgvTravelPlan.Rows.Add("BLR - PUN", "26 May - 27 May", "Open", "£43", ">");

            //dgvTravelPlan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //dgvTravelPlan.AllowUserToResizeColumns = true;
            //dgvTravelPlan.AllowUserToResizeRows = true;

            dgvTravelPlan.ClearSelection();
        }


        private void ReLoadPlanTravel()
        {
            //dgvTravelPlan.Rows.s
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && senderGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor==Color.LightGreen)
            {
                dgvItinerary.Rows.Clear();
                //System.Diagnostics.Process.Start("http://104.211.178.94:9001/travel_search?from=BLR&to=PNQ&time_preference=&date_of_travel=16-05-2018");
                pnlConfirmBooking.Visible = true;
                LoadItinerary(e.RowIndex);
            }
            else
                pnlConfirmBooking.Visible = false;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var dataGridView = sender as DataGridView;
            if (dataGridView.Rows[e.RowIndex].Selected)
            {
                e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                e.CellStyle.SelectionBackColor = e.CellStyle.BackColor;
            }

            foreach (var dc in dataGridView.Columns)
            {
                (dc as DataGridViewColumn).SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            DataGridViewButtonColumn dgvCol = (DataGridViewButtonColumn)dataGridView.Columns["btnOneCick"];
            dgvCol.FlatStyle = FlatStyle.Flat;
            dgvCol.DefaultCellStyle.BackColor = Color.WhiteSmoke;

            //if (dc is DataGridViewButtonColumn && dataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor!=Color.LightGray)
            //    {
            //        (dc as DataGridViewButtonColumn).Visible = false;
            //    }

            //if (dataGridView.CurrentRow.DefaultCellStyle.BackColor != Color.LightGreen)
            //{
            //    DataGridViewTextBoxCell txtcell = new DataGridViewTextBoxCell();
            //    dataGridView.CurrentRow.Cells[4].Value = txtcell; 
            //}

        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            String strValue = dgvTravelPlan.Rows[e.RowIndex].Cells[3].Value.ToString();
            dgvTravelPlan.Rows[e.RowIndex].Cells[4].Style.BackColor = Color.White;

            if (bConfirmBooking && dgvTravelPlan.Rows[e.RowIndex].Cells[2].Value.ToString() == "Booked")
            {
                dgvTravelPlan.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGray;
                ///dgvTravelPlan.Rows[e.RowIndex].Cells[4].Value = new Bitmap(1, 1);
            }
            else
            {
                switch (strValue)
                {
                    case "£380":
                        dgvTravelPlan.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightPink;
                        break;
                    case "£560":
                    case "£1425":
                        dgvTravelPlan.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightYellow;
                        break;
                    default:
                        dgvTravelPlan.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                        break;
                }
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your travel itinerary has been sent for booking.");
            pnlConfirmBooking.Visible = false;

            dgvItinerary.Rows.Clear();

            if (dgvTravelPlan.SelectedRows.Count != 0)
            {
                dgvTravelPlan.SelectedRows[0].Cells[2].Value = "Booked";
                bConfirmBooking = true;
                dgvTravelPlan.SelectedRows[0].DefaultCellStyle.SelectionBackColor = Color.LightGray;

                dgvTravelPlan.SelectedRows[0].Cells[2].Style.NullValue = null;
                dgvTravelPlan.SelectedRows[0].Cells[4].Value = "";
            }

            //Outlook.Application oApp = new Outlook.Application();
            //Outlook._MailItem oMailItem = (Outlook._MailItem)oApp.CreateItem(Outlook.OlItemType.olMailItem);
            //oMailItem.To = "pavithra.jayarajan@arimonconsulting.com";
            //oMailItem.Subject = "Travel itinerary has been sent for booking.";
            //oMailItem.Body = "";

            //oMailItem.Display(true);

            String userName = "rajesh.ramaswamy@arimonconsulting.com";
            String password = "Apr@2018";
            MailMessage msg = new MailMessage();
            msg.To.Add(new MailAddress("rajesh.ramaswamy@arimonconsulting.com"));
            //msg.To.Add(new MailAddress("pavithra.jayarajan@arimonconsulting.com"));
            msg.From = new MailAddress(userName, "TravelyseNotifications");
            msg.Subject = "Booking initiated for route: " + dgvTravelPlan.SelectedRows[0].Cells[0].Value.ToString();
            msg.Body = "Hi, Well done!You booking request has been sent to the travel desk Booking confirmation and tickets will be sent in a separate email.This is an automated email.";
            msg.IsBodyHtml = true;
            SmtpClient client = new SmtpClient();
            client.Host = "smtp.office365.com";
            client.Credentials = new System.Net.NetworkCredential(userName, password);
            client.Port = 587;
            client.EnableSsl = true;
            client.Send(msg);
        }

        //private void dataGridView1_CellValueChanged(object sender, DataGridViewCellValueEventArgs e)
        //{
        //    dgvTravelPlan.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGray;

        //}

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dgvItinerary.Rows.Clear();
            pnlConfirmBooking.Visible = false;
        }

        private void LoadItinerary(int i)
        {
            dgvItinerary.Columns.Add("colItems", "");
            dgvItinerary.Columns.Add("colDetails", "");

            if (i == 2)
            {
                dgvItinerary.Rows.Add("Flight:", "British Airways");
                dgvItinerary.Rows.Add("Time:", "6:00pm - 9:00pm");
                dgvItinerary.Rows.Add("Class:", "Business");
                dgvItinerary.Rows.Add("Route:", "Direct");
                dgvItinerary.Rows.Add("Seat:", "Window");
                dgvItinerary.Rows.Add("Meal:", "Vegetarian");
            }
            else
            {
                dgvItinerary.Rows.Add("Flight:", "Air India");
                dgvItinerary.Rows.Add("Time:", "5:00am - 8:00am");
                dgvItinerary.Rows.Add("Class:", "Ecconomy");
                dgvItinerary.Rows.Add("Route:", "Direct");
                dgvItinerary.Rows.Add("Seat:", "Aisle");
                dgvItinerary.Rows.Add("Meal:", "Vegetarian");
            }

            dgvItinerary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvItinerary.ClearSelection();
        }

        private void dgvItinerary_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var dataGridView = sender as DataGridView;
            dataGridView.Columns[0].DefaultCellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            dgvTravelPlan.Columns.Clear();
            dgvTravelPlan.Rows.Clear();
            LoadData();
        }
    }
}
