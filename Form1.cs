namespace solucionTaller2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Btncalcular_Click(object sender, EventArgs e)
        {
            /*Se inicializan las variables*/
            double numeroApt = 0,
                piscina = 0,
                juegos = 0,
                aseo = 0,
                niños = 0,
                adultos = 0,
                zonaS = 0,
                subtotal = 0,
                total = 0;
                
            double 
                dsto = 0;

            string dueño = ""
                  , inquilino = "";

            /*Se asiganan los controles que entran por teclado a las variables*/
            numeroApt = int.Parse(CbxNumApt.Text);
            dueño= TxtDueño.Text;
            inquilino= TxtInquilino.Text;
            niños = int.Parse(TxtNiños.Text);
            adultos = int.Parse(TxtAdultos.Text);

            /*validaciones*/
            if (inquilino != "0")
            {
                if (adultos > 0)
                {
                    piscina = adultos * 1000;
                }

                if (niños > 0)
                {
                    juegos = 5000;
                }
                if (numeroApt < 300)
                {
                    aseo = 15000;
                }
                zonaS = 10000;
                subtotal = piscina + juegos + aseo + zonaS;

                if (dueño == inquilino)
                {
                    dsto = subtotal * 0.2;
                }

            }
            total= subtotal+33000 - dsto;
            /*Se muestra el resumanen del resultado al cliente en el label*/
         
            LblTotalPagar2.Text = "Cargo fijo: $33000 \r\n";
            LblTotalPagar2.Text += "Piscina: $ "+piscina+ "\r\n";
            LblTotalPagar2.Text += "Juegos: $ " + juegos + "\r\n";
            LblTotalPagar2.Text += "Zona Social: $ " + zonaS + "\r\n";
            LblTotalPagar2.Text += "Aseo: $ " + aseo + "\r\n";
            LblTotalPagar2.Text += "SubTotal: $ " + subtotal + "\r\n";
            LblTotalPagar2.Text += "Descuento:$ " + dsto + "\r\n";
            LblTotalPagar2.Text += "Total: $ " + total + "\r\n"+"\r\n";
          
            

        }
        /*validaciones
           int numeroApto = int.Parse(CbxApto.Text);*/

            /*if ( numeroApto > 300)
            {
                LblPagar.Text = "No paga aseo";
            }
            else
            {
                LblPagar.Text = "15000";
            }*/

            private void Form1_Load(object sender, EventArgs e)
        {
            CbxNumApt.Text="0";
            TxtDueño.Text="0";
            TxtInquilino.Text="0";
            TxtNiños.Text="0";
            TxtAdultos.Text="0";
        }

        
    }
}