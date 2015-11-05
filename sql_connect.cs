
string Name= "query";
string constr = "Data Source=XIAOHONG-PC;Initial Catalog=asp;Persist Security Info=True;User ID=sa;Password=pwd";
SqlConnection con = new SqlConnection(constr);
con.Open();
SqlCommand cmd = new SqlCommand();
cmd.Connection = con;
string sql = "select price from your_table where Name=@Name";
cmd.CommandText = sql;
cmd.Parameters.AddWithValue("Name", Name);

// 第一种方法
SqlDataReader rd = cmd.ExecuteReader();
double Price = 0;
if (rd.Read())
{
	Price = Convert.ToDouble(rd["Price"]);
}

JavaScriptSerializer jss = new JavaScriptSerializer();
Response.ContentType = "application/json";
Response.Write(jss.Serialize(Price));
Response.End();