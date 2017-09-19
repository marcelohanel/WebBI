using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace ClassWebBI.Dados
{
    public class ClassUsuarios
    {
        private int _cod_usuario;
        private string _nome;
        private string _usuario;
        private string _senha;
        private string _endereco_mail;
        private bool _administrador;
        private string _usuario_mail;
        private string _senha_mail;
        private string _servidor_mail;
        private int _porta_mail;
        private bool _ssl;
    
        public int fcod_usuario
        {
            get
            {
                return _cod_usuario;
            }
            set
            {
                _cod_usuario = value;
            }
        }

        public string fnome
        {
            get
            {
                return _nome;
            }
            set
            {
                _nome = value;
            }
        }

        public string fusuario
        {
            get
            {
                return _usuario;
            }
            set
            {
                _usuario = value;
            }
        }

        public string fsenha
        {
            get
            {
                return _senha;
            }
            set
            {
                _senha = value;
            }
        }

        public string fendereco_mail
        {
            get
            {
                return _endereco_mail;
            }
            set
            {
                _endereco_mail = value;
            }
        }

        public bool fadministrador
        {
            get
            {
                return _administrador;
            }
            set
            {
                _administrador = value;
            }
        }

        public bool fssl
        {
            get
            {
                return _ssl;
            }
            set
            {
                _ssl = value;
            }
        }

        public string fusuario_mail
        {
            get
            {
                return _usuario_mail;
            }
            set
            {
                _usuario_mail = value;
            }
        }

        public string fsenha_mail
        {
            get
            {
                return _senha_mail;
            }
            set
            {
                _senha_mail = value;
            }
        }

        public string fservidor_mail
        {
            get
            {
                return _servidor_mail;
            }
            set
            {
                _servidor_mail = value;
            }
        }

        public int fporta_mail
        {
            get
            {
                return _porta_mail;
            }
            set
            {
                _porta_mail = value;
            }
        }

        public void getUsuario(int CodUsuario)
        {
            ClassFuncoes clFuncoes = new ClassFuncoes();

            SqlCommand sCommand = new SqlCommand();
            DataTable tblUsuarios = new DataTable();

            SqlParameter pCodigo = new SqlParameter("@COD_USUARIO", System.Data.SqlDbType.Int);
            sCommand.Parameters.Add(pCodigo);
            sCommand.Parameters["@COD_USUARIO"].Value = CodUsuario;

            sCommand.CommandText = "SELECT COD_USUARIO, NOME, USUARIO, SENHA, ENDERECO_MAIL, ADMINISTRADOR, USUARIO_MAIL, SENHA_MAIL, SERVIDOR_MAIL, PORTA_MAIL, UTILIZAR_SSL FROM USUARIOS" +
                " WHERE COD_USUARIO = @COD_USUARIO";

            tblUsuarios = clFuncoes.ExecReader(sCommand);

            if (tblUsuarios.Rows.Count > 0)
            {
                fcod_usuario = Convert.ToInt32(tblUsuarios.Rows[0]["COD_USUARIO"].ToString());
                fnome = tblUsuarios.Rows[0]["NOME"].ToString();
                fusuario = tblUsuarios.Rows[0]["USUARIO"].ToString();
                fsenha = tblUsuarios.Rows[0]["SENHA"].ToString();
                fendereco_mail = tblUsuarios.Rows[0]["ENDERECO_MAIL"].ToString();
                fadministrador = Convert.ToBoolean(tblUsuarios.Rows[0]["ADMINISTRADOR"].ToString());
                fusuario_mail = tblUsuarios.Rows[0]["USUARIO_MAIL"].ToString();
                fsenha_mail = tblUsuarios.Rows[0]["SENHA_MAIL"].ToString();
                fservidor_mail = tblUsuarios.Rows[0]["SERVIDOR_MAIL"].ToString();
                fporta_mail = Convert.ToInt32(tblUsuarios.Rows[0]["PORTA_MAIL"].ToString());
                fssl = Convert.ToBoolean(tblUsuarios.Rows[0]["UTILIZAR_SSL"].ToString());
            }
        }

        public void getUsuario(string Usuario)
        {
            ClassFuncoes clFuncoes = new ClassFuncoes();

            SqlCommand sCommand = new SqlCommand();
            DataTable tblUsuarios = new DataTable();

            SqlParameter pUsuario = new SqlParameter("@USUARIO", System.Data.SqlDbType.VarChar, 20);
            sCommand.Parameters.Add(pUsuario);
            sCommand.Parameters["@USUARIO"].Value = Usuario;

            sCommand.CommandText = "SELECT COD_USUARIO FROM USUARIOS" +
                " WHERE USUARIO = @USUARIO";

            tblUsuarios = clFuncoes.ExecReader(sCommand);

            if (tblUsuarios.Rows.Count > 0)
                getUsuario(Convert.ToInt32(tblUsuarios.Rows[0]["COD_USUARIO"].ToString()));
        }

        public DataTable getUsuarios(string OrderBy)
        {
            ClassFuncoes clFuncoes = new ClassFuncoes();

            SqlCommand sCommand = new SqlCommand();
            DataTable tblUsuarios = new DataTable();

            if (OrderBy != "")
            {
                sCommand.CommandText = "SELECT COD_USUARIO, NOME, USUARIO, ADMINISTRADOR FROM USUARIOS ORDER BY " + OrderBy;
            }
            else
            {
                sCommand.CommandText = "SELECT COD_USUARIO, NOME, USUARIO, ADMINISTRADOR FROM USUARIOS";
            }

            tblUsuarios = clFuncoes.ExecReader(sCommand);

            return tblUsuarios;
        }

        public string delUsuario(int CodUsuario)
        {
            ClassWebBI.ClassFuncoes clFuncoes = new ClassWebBI.ClassFuncoes();

            SqlCommand sCommand = new SqlCommand();

            SqlParameter pCodUsuario = new SqlParameter("@COD_USUARIO", System.Data.SqlDbType.Int);
            sCommand.Parameters.Add(pCodUsuario);
            sCommand.Parameters["@COD_USUARIO"].Value = CodUsuario;
            sCommand.CommandText = "DELETE FROM USUARIOS WHERE COD_USUARIO = @COD_USUARIO";

            string sAux = clFuncoes.ExecNonQuery(sCommand);

            return sAux;
        }

        public int getMaxCodUsuario()
        {
            ClassWebBI.ClassFuncoes clFuncoes = new ClassWebBI.ClassFuncoes();
            SqlCommand sCommand = new SqlCommand();

            sCommand.Parameters.Clear();
            sCommand.CommandText = "SELECT MAX(COD_USUARIO) AS NUM_USUARIOS FROM USUARIOS";

            string sAux = clFuncoes.ExecScalar(sCommand);

            int iCodigo = 1;

            try
            {
                iCodigo = Convert.ToInt32(sAux) + 1;
            }
            catch
            {
            }

            return iCodigo;
        }

        public string setUsuario(string Tipo)
        {
            ClassWebBI.ClassFuncoes clFuncoes = new ClassWebBI.ClassFuncoes();
            SqlCommand sCommand = new SqlCommand();

            SqlParameter pCodigo = new SqlParameter("@COD_USUARIO", System.Data.SqlDbType.Int);
            sCommand.Parameters.Add(pCodigo);
            sCommand.Parameters["@COD_USUARIO"].Value = fcod_usuario;

            SqlParameter pNome = new SqlParameter("@NOME", System.Data.SqlDbType.VarChar, 50);
            sCommand.Parameters.Add(pNome);
            sCommand.Parameters["@NOME"].Value = fnome;

            SqlParameter pUsuario = new SqlParameter("@USUARIO", System.Data.SqlDbType.VarChar, 20);
            sCommand.Parameters.Add(pUsuario);
            sCommand.Parameters["@USUARIO"].Value = fusuario;

            SqlParameter pSenha = new SqlParameter("@SENHA", System.Data.SqlDbType.VarChar, 20);
            sCommand.Parameters.Add(pSenha);
            sCommand.Parameters["@SENHA"].Value = fsenha;

            SqlParameter pMail = new SqlParameter("@MAIL", System.Data.SqlDbType.VarChar, 100);
            sCommand.Parameters.Add(pMail);
            sCommand.Parameters["@MAIL"].Value = fendereco_mail;

            SqlParameter pAdmin = new SqlParameter("@ADMIN", System.Data.SqlDbType.Bit);
            sCommand.Parameters.Add(pAdmin);
            sCommand.Parameters["@ADMIN"].Value = fadministrador;

            SqlParameter pSSL = new SqlParameter("@SSL", System.Data.SqlDbType.Bit);
            sCommand.Parameters.Add(pSSL);
            sCommand.Parameters["@SSL"].Value = fssl;

            SqlParameter pUsuarioMail = new SqlParameter("@USUARIO_MAIL", System.Data.SqlDbType.VarChar, 50);
            sCommand.Parameters.Add(pUsuarioMail);
            sCommand.Parameters["@USUARIO_MAIL"].Value = fusuario_mail;

            SqlParameter pSenhaMail = new SqlParameter("@SENHA_MAIL", System.Data.SqlDbType.VarChar, 50);
            sCommand.Parameters.Add(pSenhaMail);
            sCommand.Parameters["@SENHA_MAIL"].Value = fsenha_mail;

            SqlParameter pServidorMail = new SqlParameter("@SERVIDOR_MAIL", System.Data.SqlDbType.VarChar, 50);
            sCommand.Parameters.Add(pServidorMail);
            sCommand.Parameters["@SERVIDOR_MAIL"].Value = fservidor_mail;

            SqlParameter pPortaMail = new SqlParameter("@PORTA_MAIL", System.Data.SqlDbType.Int);
            sCommand.Parameters.Add(pPortaMail);
            sCommand.Parameters["@PORTA_MAIL"].Value = fporta_mail;

            if (Tipo == "Incluir")
                sCommand.CommandText = "INSERT INTO USUARIOS (COD_USUARIO, NOME, USUARIO, SENHA, ENDERECO_MAIL, ADMINISTRADOR, USUARIO_MAIL, SENHA_MAIL, SERVIDOR_MAIL, PORTA_MAIL, UTILIZAR_SSL)" +
                    " VALUES (" +
                    "  @COD_USUARIO" +
                    ", @NOME" +
                    ", @USUARIO" +
                    ", @SENHA" +
                    ", @MAIL" +
                    ", @ADMIN" +
                    ", @USUARIO_MAIL" +
                    ", @SENHA_MAIL" +
                    ", @SERVIDOR_MAIL" +
                    ", @PORTA_MAIL" +
                    ", @SSL)";
            else
                sCommand.CommandText = "UPDATE USUARIOS" +
                    " SET NOME = @NOME" +
                    " , SENHA = @SENHA" +
                    " , ENDERECO_MAIL = @MAIL" +
                    " , ADMINISTRADOR = @ADMIN" +
                    " , USUARIO_MAIL = @USUARIO_MAIL" +
                    " , SENHA_MAIL = @SENHA_MAIL" +
                    " , SERVIDOR_MAIL = @SERVIDOR_MAIL" +
                    " , PORTA_MAIL = @PORTA_MAIL" +
                    " , UTILIZAR_SSL = @SSL" +
                    " WHERE COD_USUARIO = @COD_USUARIO";

            string sAux = clFuncoes.ExecNonQuery(sCommand);

            return sAux;
        }
    }
}
