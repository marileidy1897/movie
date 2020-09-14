using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using movie.BLL;

namespace movie.DAL
{
    class actorDAL
    {
        conexionDALL conexion;
        public actorDAL()
        {
            conexion = new conexionDALL();
        }

        public bool ADD(actorBLL oactorBLL)
        {
            return conexion.Command("INSERT INTO actorTable (name ,img ) VALUES ('"+ oactorBLL.Name+","+ oactorBLL.Img + "');");
        }

        public DataSet ShowActor()
        {
            SqlCommand query = new SqlCommand("Select * from actorTable");
            return conexion.CommandQuery(query);

        }
        public bool Delete(actorBLL oactorBLL)
        {
            return conexion.Command("Delete from actorTable where id='" + oactorBLL.ID+"');");
        }
        public bool Edit(actorBLL oactorBLL)
        {
            return conexion.Command("Delete from actorTable where id='" + oactorBLL.ID + "');");
        }

    }
}
