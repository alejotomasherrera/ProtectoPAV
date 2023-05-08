namespace ProyectoPAV;

using ProyectoPAV.Entidades;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public partial class LoginForm : Form
{
    public LoginForm()
    {
        InitializeComponent();
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
        Usuario usu = new Usuario(txtUsuario.Text, txtContraseña.Text);

        string usuCorrecto = "juan";
        string pass = "123";
        if (txtUsuario.Text.Equals(usuCorrecto) && txtContraseña.Text.Equals(pass))
        {
            //Usuario correcto
            MessageBox.Show("Datos Correctos!!!");
            PrinicipalForm ventana = new PrinicipalForm(usu);
            ventana.Show();
            this.Hide();
        }
        else
        {
            //Usuario Incorrecto
            MessageBox.Show("Ingrese valores correctos", "Error al iniciar sesion");
        }
    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {

    }
}