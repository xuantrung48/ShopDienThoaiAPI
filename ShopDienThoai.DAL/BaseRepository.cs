﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ShopDienThoai.DAL
{
    public class BaseRepository
    {
        protected IDbConnection conn;
        public BaseRepository()
        {
            var connectionString = "Data Source=DESKTOP-5V9HDF2\\SQLEXPRESS01;Initial Catalog=ShopDienThoai;Integrated Security=True";
            conn = new SqlConnection(connectionString);
        }
    }
}
