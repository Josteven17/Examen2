using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace JosephOvarezExamen2
{
    public class Cliente
    {
            public static int Codigo { get; set; }
            private static String Nombre { get; set; }
            private static String Cedula { get; set; }
            private static String Telefono { get; set; }
            private static String Direccion { get; set; }

            private static String Mes { get; set; }
            private static float Monto { get; set; }

            private static float Descuento { get; set; }

            private static float Subtotal { get; set; }
            private static float Iva { get; set; }

            private static float Total { get; set; }

            static int factura = 0;


            public Cliente(String nombre, int codigo, String mes, String cedula, String telefono, String direccion, float monto, float descuento, float subtotal, float iva, float total)
            {
                Nombre = nombre;
                Cedula = cedula;
                Telefono = telefono;
                Direccion = direccion;
                Mes = mes;
                Monto = monto;
                Descuento = descuento;
                Subtotal = subtotal;
                Iva = iva;
                Total = total;
                Codigo = codigo;
            }

            public static String GetNombre() { return Nombre; }
            public static String GetCedula() { return Cedula; }
            public static String GetTelefono() { return Telefono; }
            public static String GetDireccion() { return Direccion; }
            public static float GetMonto() { return Monto; }
            public static float GetDescuento() { return Descuento; }

            public static float GetSubtotal() { return Subtotal; }

            public static float GetIva() { return Iva; }

            public static float GetTotal() { return Total; }



            public static void SetNombre(String nombre)
            {
                Nombre = nombre;
            }
            public static void SetCodigo(int codigo)
            {
                Codigo = codigo;
            }

            public static void SetFactura()
            {
                factura = factura + 1;
            }
            public static int GetFactura()
            {
                return factura;
            }

            public static void SetMes(String mes)
            {
                Mes = mes;
            }
            public static void SetCedula(String cedula)
            {
                Cedula = cedula;
            }
            public static void SetTelefono(String telefono)
            {

                Telefono = telefono;
            }
            public static void SetDireccion(String direccion)
            {

                Direccion = direccion;
            }

            public static void SetMonto(float monto)
            {

                Monto = monto;
            }
            public static void SetDescuento(float descuento)
            {

                Descuento = descuento;
            }

            public static void SetIva(float iva)
            {

                Iva = iva;
            }
            public static void SetSubtotal(float subtotal)
            {

                Subtotal = subtotal;
            }
            public static void SetTotal(float total)
            {

                Total = total;
            }

            public static String Code(int a)
            {
                String Code = "";
                switch (a)
                {
                    case 1:
                        Code = "Agua";
                        break;
                    case 2:
                        Code = "Telefono";
                        break;
                    case 3:
                        Code = "Electricidad";
                        break;
                    case 4:
                        Code = "Internet";
                        break;

                }
                return Code;
            }

            public static void Salvar()
            {
                String strConnString = ConfigurationManager.ConnectionStrings["Examens2dbConnectionString"].ConnectionString;
                SqlConnection con = new SqlConnection(strConnString);
                con.Open();
                SqlCommand command = new SqlCommand("sp_guardar", con);
                command.Parameters.Add(new SqlParameter("@nombre", Cliente.GetNombre()));
                command.Parameters.Add(new SqlParameter("@cedula", Cliente.GetCedula()));
                command.Parameters.Add(new SqlParameter("@telefono", Cliente.GetTelefono()));
                command.Parameters.Add(new SqlParameter("@direccion", Cliente.GetDireccion()));
                command.Parameters.Add(new SqlParameter("@monto", Cliente.GetMonto()));
                command.Parameters.Add(new SqlParameter("@descuento", Cliente.GetDescuento()));
                command.Parameters.Add(new SqlParameter("@iva", Cliente.GetIva()));
                command.Parameters.Add(new SqlParameter("@subtotal", Cliente.GetSubtotal()));
                command.Parameters.Add(new SqlParameter("@total", Cliente.GetTotal()));
                command.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
            }

        }
    }
