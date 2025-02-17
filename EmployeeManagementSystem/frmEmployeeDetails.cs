using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using Models;
using Newtonsoft.Json;
using BusinessLogicLayer;
using System.Net.Http.Headers;
using System.Reflection;
using Newtonsoft.Json.Linq;
using System.Xml.Linq;

namespace EmployeeManagementSystem
{
    public partial class frmEmployeeDetails : Form
    {
        public frmEmployeeDetails()
        {
            InitializeComponent();
        }

        CommonClass objCommonClass = new CommonClass();

        private void frmEmployeeDetails_Load(object sender, EventArgs e)
        {
            ClearControls();
            btnRefresh_Click(new object(), new EventArgs());

        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {

            try
            {

                Employee_BLL objEmployee_BLL = new Employee_BLL();

                List<Employee> employeeList = new List<Employee>();

                Employee objEmployee = new Employee();

                objEmployee.id = txtSearchEmployeeID.Text;
                objEmployee.name = txtSearchEmployeeName.Text;

                int page = 1;
                int pageSize = Convert.ToInt32(objCommonClass.PageSize);

                string jsonString = string.Empty;

                jsonString = await objEmployee_BLL.GetEmployeeDetailsBasedOnSearch(objEmployee, page, pageSize);

                //employeeList = JsonConvert.DeserializeObject<List<Employee>>(jsonString);

                int totalPages = 0;
                if (jsonString.Contains("\"pages\":"))
                {
                    string totalPagesStr = jsonString.Substring(jsonString.IndexOf("\"pages\":") + 8, jsonString.IndexOf(",", jsonString.IndexOf("\"pages\":")) - jsonString.IndexOf("\"pages\":") - 8);
                    if (totalPagesStr != string.Empty)
                    {
                        totalPages = Convert.ToInt32(totalPagesStr);
                    }
                }

                if (jsonString.Contains("[{") && jsonString.Contains("}]"))
                {
                    string empDataString = jsonString.Substring(jsonString.IndexOf("[{"), jsonString.IndexOf("}]") - jsonString.IndexOf("[{") + 2);
                    employeeList = JsonConvert.DeserializeObject<List<Employee>>(empDataString);
                }

                dgvEmployeeDetails.DataSource = employeeList;

                List<int> pageNumberList = Enumerable.Range(1, totalPages).ToList();
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = pageNumberList;
                bindingNavigatorEmployee.BindingSource = bindingSource;

                if (employeeList.Count == 0)
                {
                    MessageBox.Show(this, "No records found", "No records", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                WriteErrorLog(ex.Message);
            }
            finally
            {

            }
        }

        private async void populateDataGridEmployeeBasedOnPaging(int page)
        {
            try
            {
                Employee_BLL objEmployee_BLL = new Employee_BLL();

                List<Employee> employeeList = new List<Employee>();

                Employee objEmployee = new Employee();

                objEmployee.id = txtSearchEmployeeID.Text;
                objEmployee.name = txtSearchEmployeeName.Text;

                int pageSize = Convert.ToInt32(objCommonClass.PageSize);

                string jsonString = string.Empty;

                jsonString = await objEmployee_BLL.GetEmployeeDetailsBasedOnSearch(objEmployee, page, pageSize);

                //employeeList = JsonConvert.DeserializeObject<List<Employee>>(jsonString);

                if (jsonString.Contains("[{") && jsonString.Contains("}]"))
                {
                    string empDataString = jsonString.Substring(jsonString.IndexOf("[{"), jsonString.IndexOf("}]") - jsonString.IndexOf("[{") + 2);
                    employeeList = JsonConvert.DeserializeObject<List<Employee>>(empDataString);
                }

                dgvEmployeeDetails.DataSource = employeeList;

            }
            catch (Exception ex)
            {
                WriteErrorLog(ex.Message);
            }
        }

        private async void dgvEmployeeDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0) //clicked on Edit
                {
                    txtEmployeeID.Text = dgvEmployeeDetails.Rows[e.RowIndex].Cells["ColumnEmployeeID"].Value.ToString();
                    txtEmployeeName.Text = dgvEmployeeDetails.Rows[e.RowIndex].Cells["ColumnEmployeeName"].Value.ToString();
                    txtEmail.Text = dgvEmployeeDetails.Rows[e.RowIndex].Cells["ColumnEmail"].Value.ToString();
                    cboGender.SelectedItem = dgvEmployeeDetails.Rows[e.RowIndex].Cells["ColumnGender"].Value.ToString();
                    cboStatus.SelectedItem = dgvEmployeeDetails.Rows[e.RowIndex].Cells["ColumnStatus"].Value.ToString();

                    btnAdd.Text = "Update";

                }

                if (e.ColumnIndex == 1) //clicked on Delete
                {

                    DialogResult dialogResult = MessageBox.Show("Are you sure to delete ?", "Message", MessageBoxButtons.YesNo);
                    if (dialogResult != DialogResult.Yes)
                    {
                        return;
                    }

                    string EmployeeID = dgvEmployeeDetails.Rows[e.RowIndex].Cells["ColumnEmployeeID"].Value.ToString();

                    Employee_BLL objEmployee_BLL = new Employee_BLL();

                    HttpResponseMessage httpResponse = await objEmployee_BLL.DeleteEmployee(EmployeeID);

                    if (httpResponse.IsSuccessStatusCode == true)
                    {

                        MessageBox.Show("Deletion Successful.");

                        btnRefresh_Click(new object(), new EventArgs());

                    }
                    else
                    {
                        MessageBox.Show("Deletion Failed. " + httpResponse.ReasonPhrase, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }

            }
            catch (Exception ex)
            {
                WriteErrorLog(ex.Message);
            }
        }

        private void ClearControls()
        {
            txtEmployeeID.Text = string.Empty;
            txtEmployeeName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            cboGender.SelectedIndex = -1;
            cboStatus.SelectedIndex = -1;
            btnAdd.Text = "Add";
        }

        private void btnExportCSV_Click(object sender, EventArgs e)
        {
            try
            {
                List<Employee> employeeList = new List<Employee>();

                if (dgvEmployeeDetails.DataSource != null)
                {
                    employeeList = dgvEmployeeDetails.DataSource as List<Employee>;
                }
                if (employeeList.Count == 0)
                {
                    MessageBox.Show(this, "No records were found", "No records", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "CSV|*.csv", ValidateNames = true })
                {
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (StreamWriter sw = new StreamWriter(new FileStream(saveFileDialog.FileName, FileMode.Create), Encoding.UTF8))
                        {
                            StringBuilder sb = new StringBuilder();
                            sb.AppendLine("Employee ID,Employee Name,Email,Gender,Status");

                            foreach (Employee employee in employeeList)
                            {
                                sb.AppendLine(string.Format("{0},{1},{2},{3},{4}", employee.id, employee.name, employee.email, employee.gender, employee.status));
                            }
                            sw.WriteLine(sb.ToString());

                            MessageBox.Show(this, "Data has been exported", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                WriteErrorLog(ex.Message);
            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                if (!IsValidData())
                {
                    return;
                }

                if (btnAdd.Text == "Add")
                {
                    Employee objEmployee = new Employee();
                    Employee_BLL objEmployee_BLL = new Employee_BLL();

                    objEmployee.id = txtEmployeeID.Text;
                    objEmployee.name = txtEmployeeName.Text;
                    objEmployee.email = txtEmail.Text;
                    objEmployee.gender = cboGender.SelectedItem.ToString();
                    objEmployee.status = cboStatus.SelectedItem.ToString();

                    HttpResponseMessage httpResponse = await objEmployee_BLL.CreateEmployee(objEmployee);

                    if (httpResponse.StatusCode == HttpStatusCode.Created)
                    {

                        MessageBox.Show("Created Successfully.");

                        ClearControls();

                        btnRefresh_Click(new object(), new EventArgs());

                    }
                    else
                    {
                        MessageBox.Show("Creation Failed. " + httpResponse.ReasonPhrase, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                if (btnAdd.Text == "Update")
                {
                    Employee objEmployee = new Employee();
                    Employee_BLL objEmployee_BLL = new Employee_BLL();

                    objEmployee.id = txtEmployeeID.Text;
                    objEmployee.name = txtEmployeeName.Text;
                    objEmployee.email = txtEmail.Text;
                    objEmployee.gender = cboGender.SelectedItem.ToString();
                    objEmployee.status = cboStatus.SelectedItem.ToString();

                    HttpResponseMessage httpResponse = await objEmployee_BLL.UpdateEmployee(objEmployee);

                    if (httpResponse.StatusCode == HttpStatusCode.OK)
                    {

                        MessageBox.Show("Update Successful.");

                        ClearControls();

                        btnRefresh_Click(new object(), new EventArgs());

                    }
                    else
                    {
                        MessageBox.Show("Update Failed. " + httpResponse.ReasonPhrase, "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

            }
            catch (Exception ex)
            {
                WriteErrorLog(ex.Message);
            }

        }

        private void WriteErrorLog(string errorMessage)
        {

            MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            objCommonClass.WriteErrorLog(errorMessage);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void bindingNavigatorPositionItem_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(bindingNavigatorPositionItem.Text, out _))
            {
                populateDataGridEmployeeBasedOnPaging(Convert.ToInt32(bindingNavigatorPositionItem.Text));
            }
        }

        private bool IsValidData()
        {

            if (txtEmployeeName.Text == string.Empty)
            {
                MessageBox.Show("Please enter valid Name. ", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txtEmail.Text == string.Empty)
            {
                MessageBox.Show("Please enter valid Email. ", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cboGender.SelectedItem == null)
            {
                MessageBox.Show("Please select Gender. ", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cboStatus.SelectedItem == null)
            {
                MessageBox.Show("Please select Status. ", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;

        }

        private void bindingNavigatorPositionItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 46))
            {
                e.Handled = true;
            }
        }
    }
}




