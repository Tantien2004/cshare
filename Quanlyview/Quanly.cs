using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing; // Ensure you have this using directive for Image
using System.Data.SqlClient;
using System.Net;
using System.Xml.Linq;


namespace Quanlyview
{
    public partial class Quanly : Form
    {
        private string strCon = @"Data Source=LAPTOP-7RKVICKL\MSSQLSERVER01;Initial Catalog=quan ly sinh vien;User ID=sa;Password=123456;Encrypt=False;";
        private SqlConnection sqlCon;
        public List<Employee> lstEmp = new List<Employee>();
        private BindingSource bs = new BindingSource();
        public bool isThoat = true;
        public event EventHandler DangXuat;

        private string employeeImagePath = string.Empty; // Store the image path Data Source=LAPTOP-7RKVICKL\MSSQLSERVER01;Initial Catalog="quan ly sinh vien";Persist Security Info=True;User ID=sa;Encrypt=True;Trust Server Certificate=True

        public Quanly()
        {
            InitializeComponent();
            SetupImageList();
            tbTimkiem.TextChanged += tbTimkiem_TextChanged;
            //ngay sinh
            NgaySinh.Format = DateTimePickerFormat.Custom;
            NgaySinh.CustomFormat = "dd MMMM yyyy";
            // Handle value changes (optional)
            NgaySinh.ShowUpDown = true;
        }

        private void Quanly_Load(object sender, EventArgs e)
        {
            lstEmp = GetData();
            bs.DataSource = lstEmp;
            dgvEmployee.DataSource = bs;
            SetupDataGridView(); // Setup DataGridView columns
            NgaySinh.Value = DateTime.Now; // Set the default date to now
            dgvEmployee.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        public List<Employee> GetData()
        {
            List<Employee> employee = new List<Employee>();

            using (sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();

                string query = "SELECT MaSV, TenSV, GioiTinh, NoiSinh, MaLopHoc, KhoaHoc, Anh, NgaySinh, Phone, Email FROM SV";

                using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Employee emp = new Employee
                            {
                                MaSV = reader.GetInt32(0),
                                TenSV = reader.GetString(1),
                                GioiTinh = reader.GetBoolean(2), // Updated index for Giới Tính
                                NoiSinh = reader.GetString(3),
                                MaLopHoc = reader.GetString(4).Trim(),
                                KhoaHoc = reader.GetString(5),
                                Anh = reader.IsDBNull(6) ? null : reader.GetString(6),
                                NgaySinh = reader.GetDateTime(7), // Corrected index for Ngày sinh
                                Phone = reader.GetString(8).Trim(),
                                Email = reader.GetString(9)
                            };
                            employee.Add(emp);
                        }
                    }
                }
            }
            return employee;
        }

        private void AddEmployee(Employee newEmp)
        {
            using (sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                string query = "INSERT INTO SV (MaSV, TenSV, GioiTinh, NoiSinh, MaLopHoc, KhoaHoc, Anh, NgaySinh, Phone, Email) VALUES (@MaSV, @TenSV, @GioiTinh, @NoiSinh, @MaLopHoc, @KhoaHoc, @Anh, @NgaySinh, @Phone, @Email)";

                using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                {
                    cmd.Parameters.AddWithValue("@MaSV", newEmp.MaSV);
                    cmd.Parameters.AddWithValue("@TenSV", newEmp.TenSV);
                    cmd.Parameters.AddWithValue("@GioiTinh", newEmp.GioiTinh);
                    cmd.Parameters.AddWithValue("@NoiSinh", newEmp.NoiSinh);
                    cmd.Parameters.AddWithValue("@MaLopHoc", newEmp.MaLopHoc);
                    cmd.Parameters.AddWithValue("@KhoaHoc", newEmp.KhoaHoc);
                    cmd.Parameters.AddWithValue("@Anh", newEmp.Anh);
                    cmd.Parameters.AddWithValue("@NgaySinh", newEmp.NgaySinh);
                    cmd.Parameters.AddWithValue("@Phone", newEmp.Phone);
                    cmd.Parameters.AddWithValue("@Email", newEmp.Email);



                    cmd.ExecuteNonQuery();
                }
            }
        }
        private void UpdateEmployee(Employee emp)
        {
            using (sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                string query = "UPDATE SV SET TenSV=@TenSV, GioiTinh=@GioiTinh, NoiSinh=@NoiSinh, MaLopHoc=@MaLopHoc, KhoaHoc=@KhoaHoc, Anh=@Anh, NgaySinh=@NgaySinh, Phone=@Phone, Email=@Email WHERE MaSV=@MaSV";

                using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                {
                    cmd.Parameters.AddWithValue("@MaSV", emp.MaSV);
                    cmd.Parameters.AddWithValue("@TenSV", emp.TenSV);
                    cmd.Parameters.AddWithValue("@GioiTinh", emp.GioiTinh);
                    cmd.Parameters.AddWithValue("@NoiSinh", emp.NoiSinh);
                    cmd.Parameters.AddWithValue("@MaLopHoc", emp.MaLopHoc);
                    cmd.Parameters.AddWithValue("@KhoaHoc", emp.KhoaHoc);
                    cmd.Parameters.AddWithValue("@Anh", emp.Anh);
                    cmd.Parameters.AddWithValue("@NgaySinh", emp.NgaySinh);
                    cmd.Parameters.AddWithValue("@Phone", emp.Phone);
                    cmd.Parameters.AddWithValue("@Email", emp.Email);


                    cmd.ExecuteNonQuery();
                }
            }
        }
        private void DeleteEmployee(int empId)
        {
            using (sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                string query = "DELETE FROM SV WHERE MaSV=@MaSV";

                using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                {
                    cmd.Parameters.AddWithValue("@MaSV", empId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        private void SetupDataGridView()
        {
            dgvEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmployee.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployee.Columns[0].HeaderText = "Mã SV";
            dgvEmployee.Columns[1].HeaderText = "Tên SV";
            dgvEmployee.Columns[7].HeaderText = "Ngày Sinh";
            dgvEmployee.Columns[2].HeaderText = "Giới Tính";
            dgvEmployee.Columns[3].HeaderText = "Nơi Sinh";
            dgvEmployee.Columns[5].HeaderText = "Khoa Học";
            dgvEmployee.Columns[4].HeaderText = "Mã Lớp Học";
            dgvEmployee.Columns[6].HeaderText = "Ảnh"; // Add header for Birth Date
            dgvEmployee.Columns[8].HeaderText = "Phone";
            dgvEmployee.Columns[9].HeaderText = "Email";

        }
        private void btThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btDangXuat_Click(object sender, EventArgs e)
        {
            DangXuat?.Invoke(this, EventArgs.Empty);
        }

        private void Quanly_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isThoat) Application.Exit();
        }
        private bool IsValidEmail(string email)
        {
            return email.EndsWith("@gmail.com", StringComparison.OrdinalIgnoreCase);
        }

        private bool IsValidPhoneNumber(string phone)
        {
            return phone.All(char.IsDigit);
        }

        private bool IsValidName(string name)
        {
            // Regex to allow only alphabetic characters and spaces
            return System.Text.RegularExpressions.Regex.IsMatch(name, @"^[a-zA-Z\s]+$");
        }

        private void btAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                tbMaSV.Enabled = true; // Đảm bảo mở khóa ô ID khi thêm mới

                // Kiểm tra từng trường dữ liệu có hợp lệ không
                if (string.IsNullOrWhiteSpace(tbMaSV.Text))
                {
                    MessageBox.Show("Lỗi: Vui lòng nhập mã sinh viên.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(tbTenSV.Text) || !IsValidName(tbTenSV.Text))
                {
                    MessageBox.Show("Lỗi: Tên không được chứa số và ký tự đặt biệt. Vui lòng nhập lại !");
                    return;
                }

                if (string.IsNullOrWhiteSpace(tbTenSV.Text))
                {
                    MessageBox.Show("Lỗi: Vui lòng nhập tên sinh viên.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(tbNoiSinh.Text))
                {
                    MessageBox.Show("Lỗi: Vui lòng nhập địa chỉ.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(tbPhone.Text) || !IsValidPhoneNumber(tbPhone.Text))
                {
                    MessageBox.Show("Lỗi: Số điện thoại không hợp lệ. Vui lòng chỉ nhập số.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(tbEmail.Text) || !IsValidEmail(tbEmail.Text))
                {
                    MessageBox.Show("Lỗi: Email phải có đuôi @gmail.com.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(tbMaLopHoc.Text))
                {
                    MessageBox.Show("Lỗi: Vui lòng chọn mã lớp.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(cbKhoaHoc.Text))
                {
                    MessageBox.Show("Lỗi: Vui lòng chọn ngành học.");
                    return;
                }

                if (string.IsNullOrEmpty(employeeImagePath))
                {
                    MessageBox.Show("Lỗi: Vui lòng chọn một ảnh.");
                    return;
                }

                // Kiểm tra ID có trùng lặp không
                int newId = int.Parse(tbMaSV.Text);
                if (lstEmp.Any(emp => emp.MaSV == newId))
                {
                    MessageBox.Show("Lỗi: ID đã tồn tại. Vui lòng nhập ID khác.");
                    return;
                }
<<<<<<< HEAD
=======
                if (string.IsNullOrEmpty(employeeImagePath))
                {
                    MessageBox.Show("Lỗi: Vui lòng chọn một ảnh.");
                    return;
                }

                // Nếu đường dẫn ảnh không rỗng, hãy hiển thị ảnh
                try
                {
                    Image employeeImage = Image.FromFile(employeeImagePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi hiển thị ảnh: {ex.Message}");
                }


                if (string.IsNullOrWhiteSpace(tbName.Text))
                {
                    MessageBox.Show("Lỗi: Vui lòng nhập tên hợp lệ.");
                    return;
                }

>>>>>>> origin/main

                // Tạo đối tượng Employee mới
                var newEmp = new Employee
                {
                    MaSV = newId,
                    TenSV = tbTenSV.Text,
                    GioiTinh = ckGioiTinh.Checked,
                    NoiSinh = tbNoiSinh.Text,
                    Phone = tbPhone.Text,
                    Email = tbEmail.Text,
                    MaLopHoc = tbMaLopHoc.Text,
                    KhoaHoc = cbKhoaHoc.Text,
                    Anh = employeeImagePath,
                    NgaySinh = DateTime.Now,
                };

                // Thêm vào danh sách và cập nhật DataGridView
                lstEmp.Add(newEmp);
                AddEmployee(newEmp);
                RefreshBindings();
                ClearInputFields(); // Xóa dữ liệu các ô nhập sau khi thêm xongtbId.Enabled = true; // Đảm bảo mở lại ô ID cho lần thêm tiếp theo
            }
            catch (FormatException)
            {
                MessageBox.Show("Lỗi: Vui lòng nhập số nguyên hợp lệ cho ID.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        //private bool IsValidEmail(string text)
        //{
        //    throw new NotImplementedException();
        //}

        //private bool IsValidPhoneNumber(string text)
        //{
        //    throw new NotImplementedException();
        //}

        //private bool IsValidName(string text)
        //{
        //    throw new NotImplementedException();
        //}

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.CurrentRow == null) return;

            int idx = dgvEmployee.CurrentRow.Index;
            var em = lstEmp[idx];

            try
            {
                // Capture newId directly from the input field, not from emp
                int newId = int.Parse(tbMaSV.Text);
                tbMaSV.Enabled = false;
                // Check if the new ID already exists in the list (excluding the current employee)
                if (lstEmp.Any(e => e.MaSV == newId && e != em))
                {
                    MessageBox.Show("Lỗi: ID này đã tồn tại. Vui lòng nhập ID khác.");
                    return;
                }

                em.MaSV = int.Parse(tbMaSV.Text);
                em.TenSV = tbTenSV.Text;
                em.GioiTinh = ckGioiTinh.Checked;
                em.NoiSinh = tbNoiSinh.Text;
                em.MaLopHoc = tbMaLopHoc.Text;
                em.KhoaHoc = cbKhoaHoc.Text;
                em.Anh = employeeImagePath; // Save the image path
                em.NgaySinh = NgaySinh.Value.Date; // Update the BirthDate from DateTimePicker
                em.Phone = tbPhone.Text;
                em.Email = tbEmail.Text;
                bs.ResetBindings(false);
                UpdateEmployee(em);
                ClearInputFields();
                if (!string.IsNullOrEmpty(employeeImagePath))
                {
                    em.Anh = employeeImagePath; // Cập nhật đường dẫn ảnh chỉ khi có ảnh mới được chọn
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Lỗi: Vui lòng nhập số nguyên hợp lệ cho ID.");
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.CurrentRow == null) return;

            int idx = dgvEmployee.CurrentRow.Index;
            var emId = lstEmp[idx].MaSV;

            lstEmp.RemoveAt(idx);
            DeleteEmployee(emId);
            bs.ResetBindings(false);
        }

        private void dgvEmployee_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= lstEmp.Count) return;

            Employee em = lstEmp[e.RowIndex];

            tbMaSV.Text = em.MaSV.ToString();
            tbTenSV.Text = em.TenSV;
            ckGioiTinh.Checked = em.GioiTinh;
            tbNoiSinh.Text = em.NoiSinh;
            tbMaLopHoc.Text = em.MaLopHoc;
            cbKhoaHoc.Text = em.KhoaHoc;
            NgaySinh.Value = (em.NgaySinh != DateTime.MinValue) ? em.NgaySinh : DateTime.Now;
            tbPhone.Text = em.Phone;
            tbEmail.Text = em.Email;

            // Load employee image if exists
            if (!string.IsNullOrEmpty(em.Anh) && System.IO.File.Exists(em.Anh))
            {
                pbEmployeeImage.Image = Image.FromFile(em.Anh);
                employeeImagePath = em.Anh; // Cập nhật đường dẫn ảnh
            }
            else
            {
                pbEmployeeImage.Image = null; // Clear image if not available
                employeeImagePath = string.Empty; // Đặt lại đường dẫn ảnh
            }
        }
        private void RefreshBindings()
        {
            bs.DataSource = lstEmp.ToList();
            bs.ResetBindings(false);
            dgvEmployee.ClearSelection(); // Optional: Clear selection for better UX
        }
        private void ClearInputFields()
        {
            tbMaSV.Clear();
            tbTenSV.Clear();
            tbNoiSinh.Clear();
            tbPhone.Clear();
            tbEmail.Clear();
            tbMaLopHoc.Clear(); // or clear
            cbKhoaHoc.SelectedIndex = -1; // or clear
            ckGioiTinh.Checked = false;
            NgaySinh.Value = DateTime.Now;

            if (pbEmployeeImage.Image != null)
            {
                pbEmployeeImage.Image.Dispose();
                pbEmployeeImage.Image = null; // Clear the image
            }

            employeeImagePath = string.Empty; // Reset the image path
        }

        private void SetupImageList()
        {
            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(24, 24);

            // Add images to ImageList (make sure paths are correct)
            imageList.Images.Add(Image.FromFile("Images/add.png"));    // Index 0
            imageList.Images.Add(Image.FromFile("Images/edit.png"));   // Index 1
            imageList.Images.Add(Image.FromFile("Images/delete.png")); // Index 2

            // Assign ImageList to buttons
            btAddNew.ImageList = imageList;
            btAddNew.ImageIndex = 0;

            btEdit.ImageList = imageList;
            btEdit.ImageIndex = 1;

            btDelete.ImageList = imageList;
            btDelete.ImageIndex = 2;
        }

        private void btSelectImage_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem tên đã được nhập hay chưa
            if (string.IsNullOrWhiteSpace(tbTenSV.Text))
            {
                MessageBox.Show("Lỗi: Vui lòng nhập tên trước khi chọn ảnh.");
                return;
            }

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    employeeImagePath = openFileDialog.FileName; // Store the selected image path
                    pbEmployeeImage.Image = Image.FromFile(employeeImagePath); // Display the image
                    pbEmployeeImage.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        // Method to set a specific date for the DateTimePicker (if needed)
        private void SetDateForDateTimePicker(DateTime date)
        {
            NgaySinh.Value = date; // Set a specific date, e.g. new DateTime(2024, 10, 17)
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = NgaySinh.Value;
            // Do something with the selected date
            this.Text = NgaySinh.Value.ToString("dd MMMM yyyy");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cbMaphongban_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tbMaduan_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tbTimkiem_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = tbTimkiem.Text.ToLower();

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                bs.DataSource = lstEmp; // Nếu ô tìm kiếm trống, hiển thị danh sách đầy đủ
            }
            else
            {
                var filteredList = lstEmp.Where(emp =>
                    emp.MaSV.ToString().Contains(searchTerm) || // Tìm theo mã sinh viên (chuyển sang chuỗi)
                    emp.TenSV.ToLower().Contains(searchTerm) ||
                    emp.NoiSinh.ToLower().Contains(searchTerm) ||
                    emp.Phone.Contains(searchTerm) || // Tìm theo số điện thoại
                    emp.Email.ToLower().Contains(searchTerm) ||
                    emp.MaLopHoc.ToLower().Contains(searchTerm) ||
                    emp.KhoaHoc.ToLower().Contains(searchTerm)
                ).ToList();

                bs.DataSource = filteredList; // Cập nhật BindingSource với kết quả tìm kiếm
            }

            bs.ResetBindings(false); // Làm mới DataGridView để hiển thị kết quả lọc
        }
    }
    
}
