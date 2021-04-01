using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConectXModel
{
    /// <summary>
    /// this class is responsible for interacting with database
    /// </summary>

    public class Conect_
    {

        private QL_VP_CNPMDataContext db;
        /// <summary>
        /// fetch data in Infomation table to list
        /// </summary>
        /// <returns>List Information</returns>
        public List<Information> getInformation()
        {
            List<Information> list = new List<Information>();
            using (db = new QL_VP_CNPMDataContext())
            {
                var element = db.USP_InformationTable();
                foreach(var item in element)
                {
                    Information tmp = new Information();
                    tmp.ID_card = item.ID_card;
                    tmp.Fname = item.Fname;
                    tmp.Name = item.Name;
                    tmp.dob = item.dob;
                    tmp.Adr = item.Adr;
                    list.Add(tmp);
                }
            }
            return list;
        }
        /// <summary>
        /// fetch data in vehicle table to list
        /// </summary>
        /// <returns>List Bike</returns>
        public List<vehicle> getvehicle()
        {
            List<vehicle> list = new List<vehicle>();
            using (db = new QL_VP_CNPMDataContext())
            {
                var elemet = db.USP_vehicleTable().ToList(); //convert table to list
                foreach(var item in elemet)
                {
                    vehicle tmp = new vehicle();
                    tmp.vehicle_ID = item.vehicle_ID;
                    tmp.frame_Number = item.frame_Number;
                    tmp.machine_number = item.machine_number;
                    tmp.brand = item.brand;
                    tmp.origin = item.origin;
                    list.Add(tmp);
                }
            }
            return list;
        }
        /// <summary>
        /// fetch data in request table to list
        /// </summary>
        /// <returns>List request</returns>
        public List<request> getRequest()
        {
            List<request> list = new List<request>();
            using (db = new QL_VP_CNPMDataContext())
            {
                var element = db.USP_RequestTable().ToList();
                foreach(var item in element)
                {
                    request tmp = new request();
                    tmp.ID_card = item.ID_card;
                    tmp.id = item.id;
                    tmp.conplain = item.conplain;
                    tmp.request1 = item.request;
                    tmp.reply = item.reply;
                    tmp.time_ = item.time_.GetValueOrDefault();
                    list.Add(tmp);
                }
                
            }
            return list;
        }
        /// <summary>
        /// fetch data in type_of_mistake table to list
        /// </summary>
        /// <returns>List type_of_mistake</returns>
        public List<type_of_mistake> getTypeOfMistake()
        {
            List<type_of_mistake> list = new List<type_of_mistake>();
            using (db = new QL_VP_CNPMDataContext())
            {
                var element = db.USP_ToMTable().ToList();
                foreach(var item in element)
                {
                    type_of_mistake tmp = new type_of_mistake();
                    tmp.mistake_ID = item.mistake_ID;
                    tmp.descride = item.descride;
                    tmp.content = item.descride;
                    tmp.charge = item.charge;
                    list.Add(tmp);
                }
            }
            return list;
        }
        /// <summary>
        /// fetch data in user_status table to list
        /// </summary>
        /// <returns>List user_status</returns>
        public List<user_status> getUserStatus()
        {
            List<user_status> list = new List<user_status>();
            using (db = new QL_VP_CNPMDataContext())
            {
                var element = db.USP_UserSTT().ToList();
                foreach(var item in element)
                {
                    user_status tmp = new user_status();
                    tmp.id = item.id;
                    tmp.ID_card = item.ID_card;
                    tmp.status_ = item.status_;
                    tmp.use_name = item.use_name;
                    tmp.pass = item.pass;
                    tmp.secret_answer = item.secret_answer;
                    list.Add(tmp);
                }    
            }
            return list;
        }
        /// <summary>
        /// fetch data in vehicle_X_infor table to list
        /// </summary>
        /// <returns>List vehicle</returns>
        public List<vehicle_X_infor> getVehicle_X_Infor()
        {
            List<vehicle_X_infor> list = new List<vehicle_X_infor>();
            using (db = new QL_VP_CNPMDataContext())
            {
                var element = db.USP_VehicleInforTable().ToList();
                foreach(var itm in element)
                {
                    vehicle_X_infor tmp = new vehicle_X_infor();
                    tmp.ID_card = itm.ID_card;
                    tmp.vehicle_ID = itm.vehicle_ID;
                    list.Add(tmp);
                }    
            }
            return list;
        }
        /// <summary>
        /// fetch data in vehicle_X_mistake table to list 
        /// </summary>
        /// <returns> list vehicle_X_mistake </returns>
        public List<vehicle_X_mistake> getVehicle_X_mistake()
        {
            List<vehicle_X_mistake> list = new List<vehicle_X_mistake>();
            using (db = new QL_VP_CNPMDataContext())
            {
                var element = db.USP_VehicleMistakeTable().ToList();
                foreach(var item in element)
                {
                    vehicle_X_mistake tmp = new vehicle_X_mistake();
                    tmp.vehicle_ID = item.vehicle_ID;
                    tmp.id = item.id;
                    tmp.mistake_ID = item.mistake_ID;
                    tmp.status_ = item.status_;
                 //   tmp.status_ = item.status_;
                    tmp.time_ = item.time_;
                    tmp.descride_mistake = item.descride_mistake;
                    list.Add(tmp);
                }
            }
            return list;
        }
        /// <summary>
        /// fetch data in Admin_data table to list
        /// </summary>
        /// <returns> list admin_Data</returns>
        public List<Admin_data> getAdmin()
        {
            List<Admin_data> list = new List<Admin_data>();
            using (db = new QL_VP_CNPMDataContext())
            {
                var element = db.USP_AdminTable().ToList();
                foreach(var item in element)
                {
                    Admin_data tmp = new Admin_data();
                    tmp.ID_admin = item.ID_admin;
                    tmp.use_name = item.use_name;
                    tmp.pass = item.pass;
                    list.Add(tmp);
                }
            }
            return list;
        }
        /// <summary>
        /// fetch data in history table to list
        /// </summary>
        /// <returns>history list</returns>
        public List<history> getHistory()
        {
            List<history> list = new List<history>();
            using (db = new QL_VP_CNPMDataContext())
            {
                var element = db.USP_HistoryTable().ToList();
                foreach(var item in element)
                {
                    history tmp = new history();
                    tmp.id = item.id;
                    tmp.ID_admin = item.ID_admin;
                    tmp.activity = item.activity;
                    list.Add(tmp);
                }
            }
            return list;
        }
        /// <summary>
        /// get information a member has id of diver license you fill.
        /// </summary>
        /// <param name="id_card">id of diver license.</param>
        /// <returns>Column infomation of member you want.</returns>
        public List<Information> Get_One_Infomation(string id_card)
        {
            List<Information> list = new List<Information>();
            using (db = new QL_VP_CNPMDataContext())
            {
                var item = db.USP_getInformation(id_card).SingleOrDefault();
                Information tmp = new Information();
                tmp.ID_card = item.ID_Card;
                tmp.Fname = item.FName;
                tmp.Name = item.Name;
                tmp.dob = item.dob;
                tmp.Adr = item.Adr;
                list.Add(tmp);

            }
            return list;
        }
        /// <summary>
        /// get information a vehile by vehicle numbered.
        /// </summary>
        /// <param name="vehicle_id">vehicle numbered tou want get.</param>
        /// <returns>list vehicle you need get.</returns>
        public List<vehicle> Get_One_vehicle(string vehicle_id)
        {
            List<vehicle> list = new List<vehicle>();
            using (db = new QL_VP_CNPMDataContext())
            {
                
                vehicle tmp = new vehicle();
                var item = (from t in db.vehicles
                           where t.vehicle_ID == vehicle_id
                           select t).Single();
                tmp.vehicle_ID = item.vehicle_ID;
                tmp.frame_Number = item.frame_Number;
                tmp.machine_number = item.machine_number;
                tmp.brand = item.brand;
                tmp.origin = item.origin;
                list.Add(tmp);
            }
            return list;
        }
        /// <summary>
        /// get information a Request which has id_Card and complain.
        /// </summary>
        /// <param name="id_card">the numbereddriver license you want get.</param>
        /// <returns>list request by user and reply by admin you need get.</returns>
        public List<request> Get_One_Request(string id_card)
        {
            List<request> list = new List<request>();
            using(db = new QL_VP_CNPMDataContext())
            {
                var element = db.USP_getRequest(id_card).ToList();
                foreach (var item in element)
                {
                    request tmp = new request();
                    tmp.ID_card = item.ID_card;
                    tmp.id = item.id;
                    tmp.conplain = item.conplain;
                    tmp.request1 = item.request;
                    tmp.reply = item.reply;
                    tmp.time_ = item.time_.GetValueOrDefault();
                    list.Add(tmp);
                }
            }
            return list;
        }
        /// <summary>
        /// get information a admin history.
        /// </summary>
        /// <param name="id_admin">the id of admin you want get.</param>
        /// <returns>list history admin you need get.</returns>
        public List<history> Get_One_History(int id_admin)
        {
            List<history> list = new List<history>();
            using(db = new QL_VP_CNPMDataContext())
            {
                var element = db.USP_getHistory(id_admin).ToList();
                foreach (var item in element)
                {
                    history tmp = new history();
                    tmp.id = item.id;
                    tmp.ID_admin = item.ID_admin;
                    tmp.activity = item.activity;
                    list.Add(tmp);
                }
            }
            return list;
        }
        /// <summary>
        /// get in formation a vehicle with mistake.
        /// </summary>
        /// <param name="vehicle_id">the vehicle numbered of vehicle you want see.</param>
        /// <returns>list vehicle with information you need get.</returns>
        public List<vehicle_X_mistake> Get_One_vehicle_mistake(string vehicle_id)
        {
            List<vehicle_X_mistake> list = new List<vehicle_X_mistake>();
            using (db = new QL_VP_CNPMDataContext())
            {
                var element = db.USP_getVehicleMistake(vehicle_id).ToList();
                foreach (var item in element)
                {
                    vehicle_X_mistake tmp = new vehicle_X_mistake();
                    tmp.vehicle_ID = item.vehicle_ID;
                    tmp.id = item.id;
                    tmp.mistake_ID = item.mistake_ID;
                    tmp.status_ = item.status_;
                    tmp.time_ = item.time_;
                    tmp.descride_mistake = item.descride_mistake;
                    list.Add(tmp);
                }
            }
            return list;
        }
        /// <summary>
        /// get information a admin.
        /// </summary>
        /// <param name="ID_admin">the id of admin you want get.</param>
        /// <returns>list admin data ou need get.</returns>
        public Admin_data Get_One_Admin_Data(int ID_admin)
        {
            Admin_data list = new Admin_data();
            using(db = new QL_VP_CNPMDataContext())
            {
               var a = db.USP_getAdmin(ID_admin).SingleOrDefault();
                list.ID_admin = a.ID_admin;
                list.use_name = a.use_name;
                list.pass = a.pass;
            }
            return list;
        }
        public bool admin_check(int id_admin,string pass,string name)
        {
            Admin_data a = new Admin_data();
            a.ID_admin = id_admin;
            a.use_name = name;
            a.pass = pass;
            Admin_data b = new Admin_data();
            b = Get_One_Admin_Data(id_admin);
            if(a.use_name == b.use_name && a.pass == b.pass)
            {
                return true;

            }
            else { return false; }
           
        }
        /// <summary>
        /// get in formation a mistake.
        /// </summary>
        /// <param name="mistake_ID">the numbered of mistake you want get.</param>
        /// <returns>list mistake you need get.</returns>
        public List<type_of_mistake> Get_One_Mistake(int mistake_ID)
        {
            
            List<type_of_mistake> list = new List<type_of_mistake>();
            using(db = new QL_VP_CNPMDataContext())
            {
                var item = db.USP_getToM(mistake_ID).SingleOrDefault();
                type_of_mistake tmp = new type_of_mistake();
                tmp.mistake_ID = item.mistake_ID;
                tmp.descride = item.descride;
                tmp.content = item.descride;
                tmp.charge = item.charge;
                list.Add(tmp);
            }
            return list;
        }
        /// <summary>
        /// get information a user status.
        /// </summary>
        /// <param name="id_card">the numbered of driver license you want get.</param>
        /// <returns>list user and status of user you need get.</returns>
        public List<user_status> Get_One_Userstt(string id_card)
        {

            List<user_status> list = new List<user_status>();
            using(db = new QL_VP_CNPMDataContext())
            {
                var item = db.USP_getUserSTT(id_card).SingleOrDefault();
                user_status tmp = new user_status();
                tmp.id = item.id;
                tmp.ID_card = item.ID_card;
                tmp.status_ = item.status_;
                tmp.use_name = item.use_name;
                tmp.pass = item.pass;
                tmp.secret_answer = item.secret_answer;
                list.Add(tmp);
            }
            return list;
        }
        /// <summary>
        /// get information a vehicle with information.
        /// </summary>
        /// <param name="vehicle_id">the vehicle numbered of vehicle ou want see.</param>
        /// <returns>list vehicle with informatin you need get.</returns>
        public List<vehicle_X_infor> Get_One_vehicle_infor(string vehicle_id)
        {
            List<vehicle_X_infor> list = new List<vehicle_X_infor>();
            using(db = new QL_VP_CNPMDataContext())
            {
                var item = db.USP_getVehicleinfor(vehicle_id).SingleOrDefault();
                vehicle_X_infor tmp = new vehicle_X_infor();
                tmp.ID_card = item.ID_card;
                tmp.vehicle_ID = item.vehicle_ID;
                list.Add(tmp);
            }
            return list;
        }
        /// <summary>
        /// insert data in information table.
        /// </summary>
        /// <param name="ID">the id of vehicle driverlicense.</param>
        /// <param name="fname"> first name.</param>
        /// <param name="name">last name.</param>
        /// <param name="dob">h.year of birth.a</param>
        /// <param name="addr">address.</param>
        public void insert_Informations(string ID, string fname, string name, int dob, string addr)
        {
            using (db = new QL_VP_CNPMDataContext())
            {
                db.USP_insert_information(ID,fname,name,dob,addr);
                db.SubmitChanges();
            }

        }
        /// <summary>
        /// insert data in vehicle_X_infor table.
        /// </summary>
        /// <param name="vehecle_ID">the id of vehicle.</param>
        /// <param name="ID_Card">the id of driver license.</param>
        public void insert_Vehicle_X_infors(string vehecle_ID, string ID_Card)
        {
            using (db = new QL_VP_CNPMDataContext())
            {
                db.USP_insert_vehicle_infor(ID_Card, vehecle_ID);
                db.SubmitChanges();
            }
        }
        /// <summary>
        /// inseert data in admin_data table.
        /// </summary>
        /// <param name="ID">the id of driver lincese.</param>
        /// <param name="user_Name">the name of account.</param>
        /// <param name="pass">the passwork of acccount.</param>
        public void insert_Admin_Datas(int ID, string user_Name, string pass)
        {
            using (db = new QL_VP_CNPMDataContext())
            {
                Admin_data tmp = new Admin_data();
                tmp.ID_admin = ID;
                tmp.use_name = user_Name;
                tmp.pass = pass;
                db.Admin_datas.InsertOnSubmit(tmp);
                db.SubmitChanges();
            }
        }
        /// <summary>
        /// insert data in vehicle_X_mistake table.
        /// </summary>
        /// <param name="vehicle_ID">the id of vehicle.</param>
        /// <param name="mistake_ID">the id of mistake.</param>
        /// <param name="descride_mistake"> descride mistake</param>
        /// <param name="time">the time foul.</param>
        /// <param name="status">the mistake is fines,not?</param>
        public void insert_Vehicle_X_Mistakes(string vehicle_ID, int mistake_ID, string descride_mistake, bool status, DateTime time)
        {
            using (db = new QL_VP_CNPMDataContext())
            {
                db.USP_insert_vehicle_mistake(vehicle_ID,mistake_ID,descride_mistake,status,time);
                db.SubmitChanges();
            }
        }
        /// <summary>
        /// insert data in Bike table.
        /// </summary>
        /// <param name="vehicle_ID">the id of vehicle.</param>
        /// <param name="frame_number">the id of frame vehicle</param>
        /// <param name="machine_number">the numbered machine of vehicle.</param>
        /// <param name="brand">brand of vehicle.</param>
        /// <param name="origin">origin comestic or international.</param>
        public void insert_Vehicle(string vehicle_ID, string frame_number, string machine_number, string brand, string origin)
        {
            using (db = new QL_VP_CNPMDataContext())
            {
                db.USP_insert_vehicle(vehicle_ID, frame_number, machine_number, brand, origin);
                db.SubmitChanges();
            }
        }
        /// <summary>
        /// insert data in history table.
        /// </summary>
        /// <param name="ID_admin">the id of admin.</param>
        /// <param name="activity">activity done by admin.</param>
        public void insert_Histories(int ID_admin, string activity)
        {
            using (db = new QL_VP_CNPMDataContext())
            {
                db.USP_insert_history(ID_admin, activity);
                db.SubmitChanges();
            }
        }
        /// <summary>
        /// insert data in request table.
        /// </summary>
        /// <param name="ID_card">the id of driver license.</param>
        /// <param name="complainm">the comlain by user.</param>
        /// <param name="request">the request by user.</param>
        /// <param name="reply">the reply by admin.</param>
        public void insert_requests(string ID_card, string complainm, string request, string reply)
        {
            using (db = new QL_VP_CNPMDataContext())
            {
                db.USP_insert_Request(ID_card, complainm, request, reply);
                db.SubmitChanges();
            }
        }
        /// <summary>
        /// insert data in type_of_mistake table.
        /// </summary>
        /// <param name="mistake_ID">the id of mistake.</param>
        /// <param name="content">the content of mistake.</param>
        /// <param name="descride">descride mistake.</param>
        /// <param name="charge">what charge need to fines mistake.</param>
        public void insert_type_of_mistakes(int mistake_ID, string content, string descride, decimal charge)
        {
            using (db = new QL_VP_CNPMDataContext())
            {
                db.USP_insert_ToM(mistake_ID, content, descride, charge);
                db.SubmitChanges();
            }
        }
        /// <summary>
        /// insert data in user_status table.
        /// </summary>
        /// <param name="ID_Card">the id of driver license.</param>
        /// <param name="status">this people own the driver lincense is register account in system or not?</param>
        /// <param name="user_name">the name of account.</param>
        /// <param name="pass">the password of account.</param>
        public void insert_user_status(string ID_Card, bool status, string user_name, string pass,string secrt_answer)
        {
            using (db = new QL_VP_CNPMDataContext())
            {
                db.USP_insert_UserSTT(ID_Card,status,user_name,pass, secrt_answer);
                db.SubmitChanges();
            }
        }
        /// <summary>
        /// delete admin with admin id.
        /// </summary>
        /// <param name="admin_id">the id of admin.</param>
        public void delete_admin(int admin_id)
        {
            using (db = new QL_VP_CNPMDataContext())
            {
                db.USP_deleteAdmin(admin_id);
                db.SubmitChanges();
            }
        }
        /// <summary>
        /// delete vehicle which had id is your id you fill.
        /// </summary>
        /// <param name="vehicle_ID">the numbered of vehicle.</param>
        public void delete_Vehicle(string vehicle_ID)
        {
            using (db = new QL_VP_CNPMDataContext())
            {
                db.USP_deleteVehicle(vehicle_ID);
                db.SubmitChanges();
            }

        }
        /// <summary>
        /// delete vehicle with information by numbered of driver license.
        /// </summary>
        /// <param name="id_card">numbered of driver license</param>
        public void delete_VehicleInforByIDCard(string id_card)
        {
            using (db = new QL_VP_CNPMDataContext())
            {
                db.USP_deleteVehicleInforByIdcard(id_card);
                db.SubmitChanges();
            }    
        }
        /// <summary>
        /// delete request by id_card.
        /// </summary>
        /// <param name="id_card">numbered driver license.</param>
        public void delete_Request(string id_card)
        {
            using (db = new QL_VP_CNPMDataContext())
            {
                db.USP_deleteRequest(id_card);
                db.SubmitChanges();
            }
        }
        /// <summary>
        /// delete Information by driver license.
        /// </summary>
        /// <param name="id_card"></param>
        public void delete_information(string id_card)
        {
            using (db = new QL_VP_CNPMDataContext())
            {
                var query = (from tmp in db.Informations
                             where tmp.ID_card.ToString() == id_card
                             select tmp).FirstOrDefault();

                db.Informations.DeleteOnSubmit((Information)query);
                db.SubmitChanges();
            }
        }
        /// <summary>
        /// delete mistake by mistake id.
        /// </summary>
        /// <param name="mistake_id"> id of mistake.</param>
        public void delete_Mistake(int mistake_id)
        {
            using (db = new QL_VP_CNPMDataContext())
            {
                db.USP_deleteTOM(mistake_id);
                db.SubmitChanges();

            }
        }
        /// <summary>
        /// delete mistake of vehicle follow vehicle id.
        /// </summary>
        /// <param name="vehicle_ID">vehicle id.</param>
        public void delete_vehicle_mistake(string vehicle_ID)
        {
            using(db = new QL_VP_CNPMDataContext())
            {
                db.USP_deleteVehicleMistake(vehicle_ID);
                db.SubmitChanges();

            }
        }
        /// <summary>
        /// repair the propety in prop and data repaired is data.
        /// </summary>
        /// <param name="id_Admin">id admin need repair.</param>
        /// <param name="prop">the property want repair.(Tên đăng nhập, Mật khẩu)</param>
        /// <param name="data">the data for change in property.</param>
        public void Repair_Admin_Data(int id_Admin, string prop, string data)
        {
            using(db = new QL_VP_CNPMDataContext())
            {
                db.USP_UpdateAdmin(prop, id_Admin, data);
                db.SubmitChanges();
            }
        }
        /// <summary>
        /// repair the property in prop and data after repaired is data.
        /// </summary>
        /// <param name="Vehicle_ID">the id of driver lincense.</param>
        /// <param name="prop">the property you want repair.(Số máy, Số khung, Nhãn hiệu, Xuất xứ)</param>
        /// <param name="data">the data you want after changed.</param>
        public void Repair_Vehicle_data(string Vehicle_ID, string prop, string data)
        {
            using (db = new QL_VP_CNPMDataContext())
            {
                db.USP_Updatevehicle(prop, Vehicle_ID, data);
                db.SubmitChanges();
            }
        }
        /// <summary>
        /// Reply user.
        /// </summary>
        /// <param name="id">numbered of reply.</param>
        /// <param name="data">Content of reply.</param>
        public void Reply_User(int id,string data)
        {
            using(db = new QL_VP_CNPMDataContext())
            {
                db.USP_UpdateReply(id, data);
                db.SubmitChanges();
            }    
        }
        /// <summary>
        /// Update charge of mistake.
        /// </summary>
        /// <param name="id_mistake"> numbered of mistake</param>
        /// <param name="charge">new value</param>
        public void Repair_Charge(int id_mistake,decimal charge)
        {
            using(db = new QL_VP_CNPMDataContext())
            {
                db.USP_UpdateCharge(id_mistake, charge);
                db.SubmitChanges();
            }    
        }
        /// <summary>
        /// repair the property in prop and data after repaired is data.
        /// </summary>
        /// <param name="id_mistake">the numbered of mistake</param>
        /// <param name="prop">the property you want repair.(Nội dung, Mô tả, Mức xử phạt)</param>
        /// <param name="data">the data you want after changed.</param>
        public void Repair_Mistake(int id_mistake,string prop,string data)
        {
            using(db = new QL_VP_CNPMDataContext())
            {
                db.USP_UpdateMistake(id_mistake, prop, data);
                db.SubmitChanges();
            }
                
        }
        /// <summary>
        /// repair the password when user missing.
        /// </summary>
        /// <param name="id_card">the driver license id.</param>
        /// <param name="data">the new password.</param>
        public void Repaird_Password(string id_card, string data)
        {
            using(db = new QL_VP_CNPMDataContext())
            {
                db.USP_UpdatePass(id_card, data);
                db.SubmitChanges();
            }    
        }
        /// <summary>
        /// repair the vehicle mistake is fines or not.
        /// </summary>
        /// <param name="vehicle_id">the id of driver license.</param>
        /// <param name="mistake_id">the id of mistake.</param>
        /// <param name="status">status you want change for this.</param>
        public void Repair_Fines_status(string vehicle_id,int mistake_id,bool status)
        {
            using(db = new QL_VP_CNPMDataContext())
            {
                db.USP_UpdateFinesSTT(vehicle_id, mistake_id, status);
                db.SubmitChanges();
            }    
        }
        /// <summary>
        /// user registered or not?.
        /// </summary>
        /// <param name="ID_card">numbered of driver lincense.</param>
        /// <returns></returns>
        public bool Status_user(string ID_card)
        {
            bool tmp = new bool();
            using(db = new QL_VP_CNPMDataContext())
            {
                tmp = db.USP_getUserSTT(ID_card).SingleOrDefault().status_;
            }
            return tmp;
        }
        /// <summary>
        /// the mistake is fines or not?.
        /// </summary>
        /// <param name="Vehicle_ID">id of driver lincense.</param>
        /// <param name="mistake_id">the mistask committed.</param>
        /// <param name="time_">the time committed.</param>
        /// <returns></returns>
        public bool? mistask_status(string Vehicle_ID,int mistake_id, DateTime time_)
        {
            bool? tmp = new bool?();
            using (db = new QL_VP_CNPMDataContext())
            {
                tmp = db.USP_getMistakeSTT(Vehicle_ID , mistake_id, time_).SingleOrDefault().status_;
            }
            return tmp;
        }
        /// <summary>
        /// search user infomation into tables follow driver license id.
        /// </summary>
        /// <param name="ID_card">driver linces id.</param>
        /// <returns></returns>
        public bool search_Information(string ID_card)
        {
            bool tmp = new bool();
            try
            {
                using(db = new QL_VP_CNPMDataContext())
                {
                    var element = db.USP_getInformation(ID_card).ToList();
                    if (element.Count !=0)
                    {
                        return true;
                    }
                    else if(element.Count == 0)
                    {
                        return false;
                    }
                }
                
            }catch(Exception e)
            {
                throw e;
            }
            return tmp;
        }
        /// <summary>
        /// get secret answer follow driver lincense id.
        /// </summary>
        /// <param name="ID_card">driver lincense id.</param>
        /// <returns></returns>
        public string get_Secret(string ID_card)
        {
            string str = null;
            using (db = new QL_VP_CNPMDataContext())
            {
                var element = (from tmp in db.user_status
                              where tmp.ID_card.ToString() == ID_card
                              select tmp).Single();
                str = element.secret_answer.ToString();
            }
            return str;
        }
        /// <summary>
        /// insert new secert answer into table.
        /// </summary>
        /// <param name="ID_card">driver license id.</param>
        /// <param name="data">answer in MD5 code.</param>
        public void set_Secret(string ID_card, string data)
        {
            using(db = new QL_VP_CNPMDataContext())
            {
                var element = (from tmp in db.user_status
                              where tmp.ID_card.ToString() == ID_card
                              select tmp).Single();
                element.secret_answer = data;
                db.SubmitChanges();
            }    
        }
        /// <summary>
        /// Delete all history in history table.
        /// </summary>
        public void DeleteAllHistory()
        {
            using(db = new QL_VP_CNPMDataContext())
            {
                db.USP_deleteAllHistory();
            }    
        }
    }
}
