using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace ClassWebBI.Dados
{
    public class ClassParametros
    {
        private int _cod_parametro;
        private DateTime _dt_limite_atualizacao;
        private string _mail_assunto;
        private string _mail_mensagem;
    
        public int fcod_parametro
        {
            get
            {
                return _cod_parametro;
            }
            set
            {
                _cod_parametro = value;
            }
        }

        public DateTime fdt_limite_atualizacao
        {
            get
            {
                return _dt_limite_atualizacao;
            }
            set
            {
                _dt_limite_atualizacao = value;
            }
        }

        public string fmail_assunto
        {
            get
            {
                return _mail_assunto;
            }
            set
            {
                _mail_assunto = value;
            }
        }

        public string fmail_mensagem
        {
            get
            {
                return _mail_mensagem;
            }
            set
            {
                _mail_mensagem = value;
            }
        }

        public void getParametro()
        {
            ClassFuncoes clFuncoes = new ClassFuncoes();

            SqlCommand sCommand = new SqlCommand();
            DataTable tblParametro = new DataTable();

            SqlParameter pCodigo = new SqlParameter("@COD_PARAMETRO", System.Data.SqlDbType.Int);
            sCommand.Parameters.Add(pCodigo);
            sCommand.Parameters["@COD_PARAMETRO"].Value = 1;

            sCommand.CommandText = "SELECT COD_PARAMETRO, DT_LIMITE_ATUALIZACAO, MAIL_ASSUNTO, MAIL_MENSAGEM FROM PARAMETROS WHERE COD_PARAMETRO = @COD_PARAMETRO";

            tblParametro = clFuncoes.ExecReader(sCommand);

            if (tblParametro.Rows.Count > 0)
            {
                fcod_parametro = Convert.ToInt32(tblParametro.Rows[0]["COD_PARAMETRO"].ToString());
                fdt_limite_atualizacao = Convert.ToDateTime(tblParametro.Rows[0]["DT_LIMITE_ATUALIZACAO"].ToString());
                fmail_assunto = tblParametro.Rows[0]["MAIL_ASSUNTO"].ToString();
                fmail_mensagem = tblParametro.Rows[0]["MAIL_MENSAGEM"].ToString();
            }
            else
            {
                fcod_parametro = 1;
                fdt_limite_atualizacao = DateTime.Today;
                fmail_assunto = "";
                fmail_mensagem = "";

                setParametro();
            }
        }

        public void setParametro()
        {
            ClassFuncoes clFuncoes = new ClassFuncoes();

            SqlCommand sCommand = new SqlCommand();

            SqlParameter pCodigo = new SqlParameter("@COD_PARAMETRO", System.Data.SqlDbType.Int);
            sCommand.Parameters.Add(pCodigo);
            sCommand.Parameters["@COD_PARAMETRO"].Value = 1;

            SqlParameter pDtLimiteAtualizacao = new SqlParameter("@DT_LIMITE_ATUALIZACAO", System.Data.SqlDbType.DateTime);
            sCommand.Parameters.Add(pDtLimiteAtualizacao);
            sCommand.Parameters["@DT_LIMITE_ATUALIZACAO"].Value = fdt_limite_atualizacao;

            SqlParameter pAssunto = new SqlParameter("@MAIL_ASSUNTO", System.Data.SqlDbType.VarChar, 100);
            sCommand.Parameters.Add(pAssunto);
            sCommand.Parameters["@MAIL_ASSUNTO"].Value = fmail_assunto;

            SqlParameter pMensagem = new SqlParameter("@MAIL_MENSAGEM", System.Data.SqlDbType.VarChar, 500);
            sCommand.Parameters.Add(pMensagem);
            sCommand.Parameters["@MAIL_MENSAGEM"].Value = fmail_mensagem;

            sCommand.CommandText = "SELECT COD_PARAMETRO FROM PARAMETROS WHERE COD_PARAMETRO = @COD_PARAMETRO";

            string sAux = clFuncoes.ExecScalar(sCommand);

            if (sAux != "")
                sCommand.CommandText = "UPDATE PARAMETROS" +
                    " SET DT_LIMITE_ATUALIZACAO = @DT_LIMITE_ATUALIZACAO" +
                    ",MAIL_ASSUNTO = @MAIL_ASSUNTO" +
                    ",MAIL_MENSAGEM = @MAIL_MENSAGEM" +
                    " WHERE COD_PARAMETRO = @COD_PARAMETRO";
            else
                sCommand.CommandText = "INSERT INTO PARAMETROS (COD_PARAMETRO, DT_LIMITE_ATUALIZACAO, MAIL_ASSUNTO, MAIL_MENSAGEM)" +
                    " VALUES (" +
                    "  @COD_PARAMETRO" +
                    ", @DT_LIMITE_ATUALIZACAO" +
                    ", @MAIL_ASSUNTO" +
                    ", @MAIL_MENSAGEM" +
                    ")";

            clFuncoes.ExecNonQuery(sCommand);
        }
    }
}
