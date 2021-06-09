using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace ch5
{
    public class Action
    {
        public int InsertPhoto(List<Photo> photos)
        {
            int count = 0;
            string sql = "insert into Photos (Title, Url, Sign) values (@Title, @Url, @Sign)";
            SqlDbHelper sh = new SqlDbHelper();
            foreach (var p in photos)
            {
                SqlParameter[] para = { new SqlParameter("@Title", p.Title), new SqlParameter("@Url", p.Url), new SqlParameter("@Sign", p.Sign) };
                count += sh.ExecuteNonquery(sql, CommandType.Text, para);
            }
            return count;
        }
        public List<Photo> GetImage()
        {
            string sql = "select * from Photos where Sign = 'S'";
            List<Photo> photos = null;
            using (SqlDataReader reader = SqlDbHelper.ExecuteReader(sql, CommandType.Text, new SqlConnection("Data Source=DESKTOP-7OA7319;Database=note;Integrated Security=true;"), null))
            {
                if (reader.HasRows)
                {
                    photos = new List<Photo>();
                    while (reader.Read())
                    {
                        Photo p = new Photo();
                        p.ID = reader.GetInt32(0);
                        p.Title = reader.GetString(1);
                        p.Url = reader.GetString(2);
                        photos.Add(p);
                    }
                }
            }
            return photos;
        }
    }
}