namespace Taller.Domain
{
    public class Usuario
    {
        public string User { get; set; }
        public string Clave { get; set; }
        public int NLogins { get; set; }
        public string FechaLogin { get; set; }

        public Usuario() { }

        public Usuario(string usuario, string clave, int nLogins, string fechaLogin)
        {
            this.User = usuario;
            this.Clave = clave;
            this.NLogins = nLogins;
            this.FechaLogin = fechaLogin;
        }

    }
}
