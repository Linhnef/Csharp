using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Threading.Tasks;
using OfficeOpenXml;
using System.Windows.Forms;
using System.IO;
using ConectXModel;
using System.Security.Cryptography;
using System.ComponentModel;

namespace Excute
{
    public class Done
    {
        private Conect_ conect;
        /// <summary>
        /// encode Cryptography MD5 passwork.
        /// </summary>
        /// <param name="key">passwork original</param>
        /// <returns>string cryptography MD5</returns>
        public String Cryptography_MD5(String key)
        {
            MD5 md5 = MD5.Create();
            byte[] keys_input = System.Text.Encoding.ASCII.GetBytes(key); //convert to byte array.
            byte[] hash = md5.ComputeHash(keys_input); // hash code
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            String a = sb.ToString();
            return a;
        }
        public Done()
        {
            conect = new Conect_();
        }
        /// <summary>
        /// dis play data on datagridview, follow key numbers.
        /// </summary>
        /// <param name="data">datagridview to display data</param>
        /// <param name="tmp">
        /// 
        /// 1 = display Admin_Data table
        /// 2 = display Bike table
        /// 3 = display Car table
        /// 4 = display history table
        /// 5 = display Information table
        /// 6 = display Moto table
        /// 7 = display request table
        /// 8 = display type_of_mistake table
        /// 9 = display user_status table
        /// 10 = display vehicle_X_infor table
        /// 11 = display vehicle_X_mistake table
        /// 
        /// </param>
        public void Display(DataGridView data,int tmp)
        {
            if (tmp == 1) { data.DataSource = conect.getAdmin(); }
            else if (tmp == 2) { data.DataSource = conect.getvehicle(); }
            else if (tmp == 3) { data.DataSource = conect.getHistory(); }
            else if (tmp == 4) { data.DataSource = conect.getInformation(); }
            else if (tmp == 5) { data.DataSource = conect.getRequest(); }
            else if (tmp == 6) { data.DataSource = conect.getTypeOfMistake(); }
            else if (tmp == 7) { data.DataSource = conect.getUserStatus(); }
            else if (tmp == 8) { data.DataSource = conect.getVehicle_X_Infor(); }
            else if (tmp == 9) { data.DataSource = conect.getVehicle_X_mistake(); }
        }
        /// <summary>
        /// get admin follow ID.
        /// </summary>
        /// <param name="admin_ID"> admin ID.</param>
        /// <param name="data">view show data.</param>
        public void search_Admin_(DataGridView data,int admin_ID)
        {
            data.DataSource = conect.Get_One_Admin_Data(admin_ID);
        }
        /// <summary>
        /// get iformation follow driver license.
        /// </summary>
        /// <param name="data">view show data.</param>
        /// <param name="ID_Card">driver license id.</param>
        public void search_Information(DataGridView data, string ID_Card)
        {
            data.DataSource = conect.Get_One_Infomation(ID_Card);
        }
        /// <summary>
        /// get vehicle follow vehicle license id.
        /// </summary>
        /// <param name="data">view show data.</param>
        /// <param name="Vehicle_ID">vehicle id.</param>
        public void search_Vehicle(DataGridView data, string Vehicle_ID)
        {
            data.DataSource = conect.Get_One_vehicle(Vehicle_ID);
        }
        /// <summary>
        /// get history of admin follow id_admin.
        /// </summary>
        /// <param name="data">view show data.</param>
        /// <param name="ID_admin"> id admin.</param>
        public void search_Histories(DataGridView data,int ID_admin)
        {
            data.DataSource = conect.Get_One_History(ID_admin);
        }
        /// <summary>
        /// get Request follow driver license id.
        /// </summary>
        /// <param name="data">view show data.</param>
        /// <param name="id_Card">driver license id.</param>
        public void search_Request(DataGridView data,string id_Card)
        {
            data.DataSource = conect.Get_One_Request(id_Card);
        }
        /// <summary>
        /// get mistask follow mistask id.
        /// </summary>
        /// <param name="data">view show data.</param>
        /// <param name="mistask_id">mistask id.</param>
        public void search_TOmistask(DataGridView data,int mistask_id)
        {
            data.DataSource = conect.Get_One_Mistake(mistask_id);
        }
        /// <summary>
        /// get user status of user follow driver license id.
        /// </summary>
        /// <param name="data">view show data.</param>
        /// <param name="ID_card">driver license id.</param>
        public void search_UserSTT(DataGridView data,string ID_card)
        {
            data.DataSource = conect.Get_One_Userstt(ID_card);
        }
        /// <summary>
        /// get infomation of vehicle follow vehicle id.
        /// </summary>
        /// <param name="data">view show data.</param>
        /// <param name="vehicle_ID">vehicle id</param>
        public void search_vehicle_Infor(DataGridView data,string vehicle_ID)
        {
            data.DataSource = conect.Get_One_vehicle_infor(vehicle_ID);
        }
        /// <summary>
        /// get information mistask of vehicle follow vehicle id.
        /// </summary>
        /// <param name="data">view show data.</param>
        /// <param name="vehicle_ID">vehicle id.</param>
        public void search_vehicle_Mistask(DataGridView data,string vehicle_ID)
        {
            data.DataSource = conect.Get_One_vehicle_mistake(vehicle_ID);
        }
     /*   /// <summary>
        /// fetch data Information table from excel.
        /// </summary>
        /// <param name="link">the path of excel file.</param>
        public void excel_Insert_Information(string link)
        {

            try
            {
                string path = link;
                var package = new ExcelPackage(new System.IO.FileInfo(link));
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                ExcelWorksheet ws = package.Workbook.Worksheets[0];
                int j = 3;
                for (int i = ws.Dimension.Start.Row + 1; i <= j; i++)
                {

                    try
                    {
                        if (ws.Cells[i, 1].Value == null)
                        {
                            ws.Cells[i, 1].Value = "End";
                        }
                        if ((ws.Cells[i, 1].Value == null ? string.Empty : ws.Cells[i, 1].Value.ToString()) != "End") { j = i + 1; }
                        else { break; }
                        this.insert_Informations(
                        ws.Cells[i, 1].Value == null ? string.Empty : ws.Cells[i, 1].Value.ToString(),
                        ws.Cells[i, 2].Value == null ? string.Empty : ws.Cells[i, 2].Value.ToString(),
                        ws.Cells[i, 3].Value == null ? string.Empty : ws.Cells[i, 3].Value.ToString(),
                        int.Parse(ws.Cells[i, 4].Value == null ? string.Empty : ws.Cells[i, 4].Value.ToString()),
                        ws.Cells[i, 5].Value == null ? string.Empty : ws.Cells[i, 5].Value.ToString());
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }
        /// <summary>
        /// fetch data Vehicle table from excel.
        /// </summary>
        /// <summary>
        /// fetch data Car table from excel.
        /// </summary>
        /// <param name="link">the path of excel file.</param>
        public void excel_Insert_Vehicle(string link)
        {

            try
            {
                var package = new ExcelPackage(new System.IO.FileInfo(link));
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                ExcelWorksheet ws = package.Workbook.Worksheets[0];
                int j = 3;
                for (int i = 2; i <= j; i++)
                {
                    try
                    {
                        if (ws.Cells[i, 1].Value == null)
                        {
                            ws.Cells[i, 1].Value = "End";
                        }
                        if ((ws.Cells[i, 1].Value == null ? string.Empty : ws.Cells[i, 1].Value.ToString()) != "End") { j = i + 1; }
                        else { break; }
                        this.insert_Vehicle(
                            ws.Cells[i, 1].Value == null ? string.Empty : ws.Cells[i, 1].Value.ToString(),
                            ws.Cells[i, 2].Value == null ? string.Empty : ws.Cells[i, 2].Value.ToString(),
                            ws.Cells[i, 3].Value == null ? string.Empty : ws.Cells[i, 3].Value.ToString(),
                            ws.Cells[i, 4].Value == null ? string.Empty : ws.Cells[i, 4].Value.ToString(),
                            ws.Cells[i, 5].Value == null ? string.Empty : ws.Cells[i, 5].Value.ToString());
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.ToString());
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        /// <summary>
        /// fetch data type of mistake table from excel.
        /// </summary>
        /// <param name="link">the path of excel file.</param>
        public void excel_Insert_Type_of_mistake(string link)
        {
            try
            {
                var package = new ExcelPackage(new System.IO.FileInfo(link));
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                ExcelWorksheet ws = package.Workbook.Worksheets[0];
                int j = 3;
                for (int i = ws.Dimension.Start.Row + 1; i <= j; i++)
                {
                    try
                    {
                        if (ws.Cells[i, 1].Value == null)
                        {
                            ws.Cells[i, 1].Value = "End";
                        }
                        if ((ws.Cells[i, 1].Value == null ? string.Empty : ws.Cells[i, 1].Value.ToString()) != "End") { j = i + 1; }
                        else { break; }
                        this.insert_type_mistake(
                            int.Parse(ws.Cells[i, 1].Value == null ? string.Empty : ws.Cells[i, 1].Value.ToString()),
                            ws.Cells[i, 2].Value == null ? string.Empty : ws.Cells[i, 2].Value.ToString(),
                            ws.Cells[i, 3].Value == null ? string.Empty : ws.Cells[i, 3].Value.ToString(),
                            Decimal.Parse(ws.Cells[i, 4].Value == null ? string.Empty : ws.Cells[i, 4].Value.ToString()));
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        /// <summary>
        /// fetch data user status table from excel.
        /// </summary>
        /// <param name="link">the path of excel file.</param>
        public void excel_Insert_User_status(string link)
        {
            try
            {
                var package = new ExcelPackage(new System.IO.FileInfo(link));
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                ExcelWorksheet ws = package.Workbook.Worksheets[0];
                int j = 3;
                for (int i = ws.Dimension.Start.Row + 1; i <= j; i++)
                {
                    try
                    {
                        if (ws.Cells[i, 1].Value == null)
                        {
                            ws.Cells[i, 1].Value = "End";
                        }
                        if ((ws.Cells[i, 1].Value == null ? string.Empty : ws.Cells[i, 1].Value.ToString()) != "End") { j = i + 1; }
                        else { break; }
                        bool stt = new bool();
                        if (ws.Cells[i, 2].Value.ToString() == "X") stt = false;
                        else if (ws.Cells[i, 2].Value.ToString() == "V") stt = true;
                        this.insert_status(
                            ws.Cells[i, 1].Value == null ? string.Empty : ws.Cells[i, 1].Value.ToString(),
                            stt,
                             ws.Cells[i, 3].Value == null ? string.Empty : ws.Cells[i, 3].Value.ToString(),
                             ws.Cells[i, 4].Value == null ? string.Empty : ws.Cells[i, 4].Value.ToString(),
                             ws.Cells[i, 5].Value == null ? string.Empty : ws.Cells[i, 5].Value.ToString());
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        /// <summary>
        /// fetch data vehicle information table from excel.
        /// </summary>
        /// <param name="link">the path of excel file.</param>
        public void excel_Insert_vehicle_X_Infor(string link)
        {
            try
            {
                var package = new ExcelPackage(new System.IO.FileInfo(link));
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                ExcelWorksheet ws = package.Workbook.Worksheets[0];
                    int j = 3;
                    for (int i = ws.Dimension.Start.Row + 1; i<=ws.Dimension.End.Row; i++)
                    {
                        try
                        {
                            if (ws.Cells[i, 1].Value == null)
                            {
                                ws.Cells[i, 1].Value = "End";
                            }
                            if ((ws.Cells[i, 1].Value == null ? string.Empty : ws.Cells[i, 1].Value.ToString()) != "End") { j = i + 1; }
                            else { break; }
                            this.insert_vehicle_infor(
                                ws.Cells[i, 2].Value == null ? string.Empty : ws.Cells[i, 2].Value.ToString(),
                                ws.Cells[i, 1].Value == null ? string.Empty : ws.Cells[i, 1].Value.ToString());

                        }

                        catch (Exception ex)
                        {
                            throw ex;
                        }
                    
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        /// <summary>
        /// fetch data mistake of vehicle table from excel.
        /// </summary>
        /// <param name="link">the path of excel file.</param>
        public void excel_Insert_vehicle_X_Mistake(string link)
        {
            try
            {
                var package = new ExcelPackage(new System.IO.FileInfo(link));
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                ExcelWorksheet ws = package.Workbook.Worksheets[0];
                int j = 3;
                for (int i = ws.Dimension.Start.Row + 1; i <= j; i++)
                {
                    try
                    {
                        if (ws.Cells[i, 1].Value == null)
                        {
                            ws.Cells[i, 1].Value = "End";
                        }
                        if ((ws.Cells[i, 1].Value == null ? string.Empty : ws.Cells[i, 1].Value.ToString()) != "End") { j = i + 1; }
                        else { break; }
                        bool stt = new bool();
                        if ((ws.Cells[i, 4].Value == null ? string.Empty : ws.Cells[i, 4].Value.ToString()) == "X") stt = false;
                        if ((ws.Cells[i, 5].Value == null ? string.Empty : ws.Cells[i, 5].Value.ToString()) == "V") stt = true;
                        this.insert_vehicle_mistake(
                            ws.Cells[i, 1].Value == null ? string.Empty : ws.Cells[i, 1].Value.ToString(),
                            Convert.ToInt32(ws.Cells[i, 2].Value == null ? string.Empty : ws.Cells[i, 2].Value.ToString()),
                            ws.Cells[i, 3].Value == null ? string.Empty : ws.Cells[i, 3].Value.ToString(),
                            stt,
                            DateTime.FromOADate(Double.Parse(ws.Cells[i, 5].Value == null ? string.Empty : ws.Cells[i, 5].Value.ToString())));
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public void InsertByExcel(int tmp,string link)
        {
            if(tmp == 1)
            {
                excel_Insert_Information(link);
            }else if(tmp == 2)
            {
                excel_Insert_Vehicle(link);
            }else if(tmp == 3)
            {
                excel_Insert_vehicle_X_Infor(link);
            }else if(tmp == 4)
            {
                excel_Insert_Type_of_mistake(link);
            }else if(tmp == 5)
            {
                excel_Insert_vehicle_X_Mistake(link);
            }else if(tmp == 6)
            {
                excel_Insert_User_status(link);
            }    
        }
        */
        /// <summary>
        /// insert data into Admin_data table.
        /// </summary>
        /// <param name="id_admin">the numbered of admin.</param>
        /// <param name="user_name">user name account admin.</param>
        /// <param name="pass">passwork account admin.</param>
        public void insert_Admin_datas(int id_admin,string user_name,string pass)
        {
            conect.insert_Admin_Datas(id_admin,user_name,pass);

        }
        /// <summary>
        /// insert data into vehicle_X_mistake table.
        /// </summary>
        /// <param name="vehicle">id of vehicle</param>
        /// <param name="id_mistake"> id of mistake of vehicle</param>
        /// <param name="descride">descride the mistake</param>
        /// <param name="status">don't vehicle is fines ? </param>
        /// <param name="time"> time happenning mistake.</param>
        public void insert_vehicle_mistake(string vehicle,int id_mistake,string descride,bool status,DateTime time)
        {
            conect.insert_Vehicle_X_Mistakes(vehicle, id_mistake, descride, status, time);
        }
        /// <summary>
        /// insert data into Bike table.
        /// </summary>
        /// <param name="vehicle_id">id of vehicle.</param>
        /// <param name="frame_number">frame number of vehicle.</param>
        /// <param name="machine_number">machine number of vehicle.</param>
        /// <param name="brand">brand of vehicle.</param>
        /// <param name="origin">origin of vehicle.</param>
        public void insert_Vehicle(string vehicle_id,string frame_number,string machine_number,string brand,string origin)
        {
            conect.insert_Vehicle(vehicle_id, frame_number, machine_number, brand, origin);
        }
        /// <summary>
        /// insert data into history table.
        /// </summary>
        /// <param name="id_admin"> numberd of admin.</param>
        /// <param name="activity">activity admin done.</param>
        public void insert_history(int id_admin,string activity)
        {
            conect.insert_Histories(id_admin, activity);
        }
        /// <summary>
        /// insert data into information table.
        /// </summary>
        /// <param name="id_Card">id of driver license.</param>
        /// <param name="fname">first name.</param>
        /// <param name="name">las name</param>
        /// <param name="dob">year of birth.</param>
        /// <param name="addr">address.</param>
        public void insert_Informations(string id_Card,string fname,string name,int dob,string addr)
        {
            conect.insert_Informations(id_Card, fname, name, dob, addr);
        }
        /// <summary>
        /// insert data into request table.
        /// </summary>
        /// <param name="id_Card">id of driver license.</param>
        /// <param name="complain">the complain by people.</param>
        /// <param name="request1">request by peolple.</param>
        /// <param name="reply">the reply by admin.</param>
        public void insert_Request(string id_Card,string complain,string request1,string reply)
        {
            conect.insert_requests(id_Card, complain, request1, reply);
        }
        /// <summary>
        /// insert data into type_of_mistake table.
        /// </summary>
        /// <param name="mistake_id">id of mistake.</param>
        /// <param name="content">content of mistake.</param>
        /// <param name="descride"></param>
        /// <param name="chare">charge need to fines mistake.</param>
        public void insert_type_mistake(int mistake_id,string content,string descride,decimal chare)
        {
            conect.insert_type_of_mistakes(mistake_id, content, descride, chare);
        }
        /// <summary>
        /// insert data into user_status table.
        /// </summary>
        /// <param name="id_Card">id of driver license.</param>
        /// <param name="status">the people have vehicle have account in system or not?</param>
        /// <param name="use_name">user name of account.</param>
        /// <param name="pass">password of account.</param>
        public void insert_status(string id_Card,bool status,string use_name,string pass,string secre)
        {
            conect.insert_user_status(id_Card, status, use_name, pass,secre);
        }
        /// <summary>
        /// insert data into vehicle_X_infor table.
        /// </summary>
        /// <param name="vehicle_id">id of vehicle.</param>
        /// <param name="id_Card">id of driver license.</param>
        public void insert_vehicle_infor(string vehicle_id,string id_Card)
        {
            conect.insert_Vehicle_X_infors(vehicle_id, id_Card);
        }
        /// <summary>
        /// delete admin follow admin name.
        /// </summary>
        /// <param name="id_admin">admin id.</param>
        public void Delete_Admin(int id_admin)
        {
            conect.delete_admin(id_admin);
        }
        /// <summary>
        /// delete vehicle follow driver license.
        /// </summary>
        /// <param name="Vehicle_ID">vehicle i driver license.</param>
        public void delete_Vehicle(string Vehicle_ID)
        {
            conect.delete_Vehicle(Vehicle_ID);
        }
        /// <summary>
        /// delete request follow driver license id.
        /// </summary>
        /// <param name="id_Card">id driver license.</param>
        public void delete_request(string id_Card)
        {
            conect.delete_Request(id_Card);
        }
        /// <summary>
        /// delete information follow driver license id.
        /// </summary>
        /// <param name="ID_card">driver license id.</param>
        public void delete_Information(string ID_card)
        {
            conect.delete_information(ID_card);
        }
            /// <summary>
        /// delete vehicle information with driver license.
        /// </summary>
        /// <param name="id_card">driver license.</param>
        public void delete_VehicleInforByIDCard(string id_card)
        {
            conect.delete_VehicleInforByIDCard(id_card);
        }
        /// <summary>
        /// delete mistake follow mistake id.
        /// </summary>
        /// <param name="mistake_id">mistake id.</param>
        public void delete_mistake(int mistake_id)
        {
            conect.delete_Mistake(mistake_id);
        }
        /// <summary>
        /// delete mistake mistakes by vehicle follow vehicle id and time mistakes.
        /// </summary>
        /// <param name="vehicle_id">vehicle id.</param>
        /// <param name="time">time mistakes.</param>
        public void delete_vehicle_mistakes(string vehicle_id)
        {
            conect.delete_vehicle_mistake(vehicle_id);
        }
        /// <summary>
        /// repair the propety in prop and data repaired is data.
        /// </summary>
        /// <param name="admin_id">id admin need repair.</param>
        /// <param name="prop">the property want repair.(Tên đăng nhập, Mật khẩu)</param>
        /// <param name="data">the data for change in property.</param>
        public void Update_admin(int admin_id,string prop,string data)
        {
            conect.Repair_Admin_Data(admin_id, prop, data);
        }
        /// <summary>
        /// repair the property in prop and data after repaired is data.
        /// </summary>
        /// <param name="Vehicle_ID">the id of driver lincense.</param>
        /// <param name="prop">the property you want repair.(Số máy, Số khung, Nhãn hiệu, Xuất xứ)</param>
        /// <param name="data">the data you want after changed.</param>
        public void Update_Vehicle(string Vehicle_id,string prop,string data)
        {
            conect.Repair_Vehicle_data(Vehicle_id, prop, data);
        }
        /// <summary>
        /// Reply user.
        /// </summary>
        /// <param name="id">numbered of reply.</param>
        /// <param name="data">Content of reply.</param>
        public void Update_Request(int id,string data)
        {
            conect.Reply_User(id, data);
        }
        /// <summary>
        /// update charge of mistake
        /// </summary>
        /// <param name="id_mistake">numbered of mistake</param>
        /// <param name="money">new value</param>
        public void Update_Charde(int id_mistake,decimal money)
        {
            conect.Repair_Charge(id_mistake, money);
        }    
        /// <summary>
        /// repair the property in prop and data after repaired is data.
        /// </summary>
        /// <param name="id_mistake">the numbered of mistake</param>
        /// <param name="prop">the property you want repair.(Nội dung, Mô tả, Mức xử phạt)</param>
        /// <param name="data">the data you want after changed.</param>
        public void Update_Mistake(int id_mistake,string prop,string data)
        {
            conect.Repair_Mistake(id_mistake, prop, data);
        }
        /// <summary>
        /// repair the password when user missing.
        /// </summary>
        /// <param name="id_card">the driver license id.</param>
        /// <param name="data">the new password.</param>
        public void Update_Password(string id_card,string data)
        {
            conect.Repaird_Password(id_card, data);
        }
        /// <summary>
        /// repair the vehicle mistake is fines or not.
        /// </summary>
        /// <param name="vehicle_id">the id of driver license.</param>
        /// <param name="mistake_id">the id of mistake.</param>
        /// <param name="status">status you want change for this.</param>
        public void Update_fines(string vehicle_id,int mistake_id,bool status)
        {
            conect.Repair_Fines_status(vehicle_id, mistake_id, status);
        }
        public bool Search_Information_on_Register(string ID_card)
        {
            try
            {
                return conect.search_Information(ID_card);
               
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
        /// <summary>
        /// check user name, pass.
        /// </summary>
        /// <param name="id_card">id driver license.</param>
        /// <returns></returns>
        public bool Check_login(string id_card,string username,string pass,string prop)
        {
            if (prop == "user")
            {
                user_status tmp = new user_status();
                try
                {
                    tmp = conect.Get_One_Userstt(id_card)[0];
                    if (tmp.use_name == username && tmp.pass == pass)
                    { return true; }
                    else { return false; }
                }
                catch (Exception ex)
                {
                    return false;
                    MessageBox.Show(ex.Message);
                }
            }  
            return false;
        }
        public bool Check_Admmin(int id_admin, string username, string pass)
        {
            return conect.admin_check(id_admin, pass, username);
        }
        /// <summary>
        /// Convert to string mistake of vehicle.
        /// </summary>
        /// <param name="vehicle_id">the driver license id.</param>
        /// <returns></returns>
        public string display_mistake(string vehicle_id)
        {
            List<vehicle_X_mistake> tmp = conect.Get_One_vehicle_mistake(vehicle_id);
            string str = "";
            
            for(int i =0; i<tmp.Count();i++)
            {
                string stt = "Chưa nộp phạt";
                if(tmp[i].status_ == true)
                {
                    stt = "Đã nộp phạt";
                }
                str = tmp[i].time_.ToString() + ", " + tmp[i].descride_mistake.ToString() + ", " + stt + "." + "\n";
            }
            return str;
        }
        /// <summary>
        /// delete all history in history table.
        /// </summary>
        public void deleteAllHistory()
        {
            conect.DeleteAllHistory();
        }
        /// <summary>
        /// Export histories to word file.
        /// </summary>
        /// <param name="data">histories.</param>
        public void exportWord(string data)
        {
            
        }
        /// <summary>
        /// delete all history.de
        /// </summary>
        /// <returns></returns>
        public string showHistory()
        {
            string str = "";
            List<history> tmp = new List<history>();
            tmp = conect.getHistory();
            foreach(history item in tmp)
            {
                str += item.ID_admin + "    " + item.activity + "\n";
            }
            return str;                        
        } 
        /// <summary>
        /// Check the secret answer to recover pass word.
        /// </summary>
        /// <param name="id_Card"> the driver lincense numbered.</param>
        /// <param name="secre">the secret answer after encoding MD5 </param>
        /// <returns></returns>
        public bool Check_Secre(string id_Card,string secre)
        {
            try
            {
                string tmp = conect.Get_One_Userstt(id_Card)[0].secret_answer.ToString();
                if (Cryptography_MD5(secre) == tmp) 
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }catch(Exception ex)
            {
                throw ex;
                return false;
            }
        }
        /// <summary>
        /// get user name.
        /// </summary>
        /// <param name="id_card"> the driver lincense id.</param>
        /// <returns></returns>
        public string Get_useName(string id_card)
        {
            try
            {
                return conect.Get_One_Userstt(id_card)[0].use_name;
            }catch(Exception ex)
            {
                throw ex;
                return null;
            }
        }

    }
    

}
