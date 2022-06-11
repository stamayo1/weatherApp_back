using Dato;
using Newtonsoft.Json;
using Npgsql;
using System;
using System.Data;
using System.Security.Cryptography;
using System.Text;

namespace Weather.Data
{

    public class UsuarioData
    {
        private readonly string _Cn = "server=ec2-23-20-73-25.compute-1.amazonaws.com; puerto=5432; datase= de4chsd8k9qlh2; Users Id=tqlaaytmmythuz;Password= dafe343a321d9369c48b2f6422e487047cb30c0eaf9c2b71e6bc812923a4dcc0;";
        public static string encrypt(string dto, string key)
        {
            byte[] keyArray;
            byte[] encrypt = Encoding.UTF8.GetBytes(dto);

            keyArray = Encoding.UTF8.GetBytes(key);

            var tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateEncryptor();
            byte[] result = cTransform.TransformFinalBlock(encrypt, 0, encrypt.Length);
            tdes.Clear();

            return Convert.ToBase64String(result, 0, result.Length);

        }
        public static model Registrar(model oUsuario)
        {
            NpgsqlConnection cn = new NpgsqlConnection();
            cn.ConnectionString = "server=ec2-54-157-16-196.compute-1.amazonaws.com;port=5432;user id=tqlaaytmmythuz;password=dafe343a321d9369c48b2f6422e487047cb30c0eaf9c2b71e6bc812923a4dcc0;database=de4chsd8k9qlh2;";
            cn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.CommandText = "signup.usp_register";
            cmd.CommandType = CommandType.StoredProcedure;
            oUsuario.UsersPassword = encrypt(oUsuario.UsersPassword, "a781jslapo0193ik");
            var json = JsonConvert.SerializeObject(oUsuario);
            cmd.Parameters.AddWithValue(json);
            cmd.Connection = cn;
            var response = cmd.ExecuteScalar();
            model us = JsonConvert.DeserializeObject<model>(response.ToString());
            return us;
        }
        public static LoginResponse Login(model users)
        {
            NpgsqlConnection cn = new NpgsqlConnection();
            cn.ConnectionString = "server=ec2-54-157-16-196.compute-1.amazonaws.com;port=5432;user id=tqlaaytmmythuz;password=dafe343a321d9369c48b2f6422e487047cb30c0eaf9c2b71e6bc812923a4dcc0;database=de4chsd8k9qlh2;";
            cn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.CommandText = "signup.usp_login";
            cmd.CommandType = CommandType.StoredProcedure;
            users.UsersPassword = encrypt(users.UsersPassword, "a781jslapo0193ik");
            var json = JsonConvert.SerializeObject(users);
            cmd.Parameters.AddWithValue(json);
            cmd.Connection = cn;
            var response = cmd.ExecuteScalar();
            var us = JsonConvert.DeserializeObject<LoginResponse>(response.ToString());
            return us;
        }
        public static RegisterClimateDto RegisterClimate(RegisterClimateDto register)
        {
            NpgsqlConnection cn = new NpgsqlConnection();
            cn.ConnectionString = "server=ec2-54-157-16-196.compute-1.amazonaws.com;port=5432;user id=tqlaaytmmythuz;password=dafe343a321d9369c48b2f6422e487047cb30c0eaf9c2b71e6bc812923a4dcc0;database=de4chsd8k9qlh2;";
            cn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.CommandText = "signup.usp_register_climate";
            cmd.CommandType = CommandType.StoredProcedure;
            var json = JsonConvert.SerializeObject(register);
            cmd.Parameters.AddWithValue(json);
            cmd.Connection = cn;
            var response = cmd.ExecuteScalar();
            var us = JsonConvert.DeserializeObject<RegisterClimateDto>(response.ToString());
            return us;
        }
    }
}
