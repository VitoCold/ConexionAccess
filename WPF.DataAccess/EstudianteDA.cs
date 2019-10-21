using Dapper;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF.Entities;

namespace WPF.DataAccess
{
    public class EstudianteDA:BaseDA
    {
        public EstudianteDA()
        {
            //SqlMapperExtensions.TableNameMapper =
            //    (type) => { return $"[Estudiante]"; };

        }

        public List<Estudiante> GetAlumnos()
        {
            var result = new List<Estudiante>();

            using (var cnx = new OleDbConnection(this.GetCnxStringColegio))
            {
                try
                {
                    var sql = "select * from Estudiante ";
                    result = cnx.Query<Estudiante>(sql).ToList();
                    //result = cnx.GetAll<Estudiante>().ToList();
                }
                catch (Exception ex)
                {

                }
            }

            return result;
        }

        public int AddAlumno(Estudiante alumno)
        {
            using (var cnx = new OleDbConnection(this.GetCnxStringColegio))
            {
                try
                {
                    var parameters = new { alumno.Nombre, alumno.Apellido };
                    return cnx.Execute("insert into Estudiante(Nombre,Apellido) Values(@Nombre,@Apellido) ", parameters);
                    //return (int)cnx.Insert<Estudiante>(alumno);
                    //return 1;
                }
                catch (Exception ex)
                {
                    return 0;
                }
            }
        }
    }
}
