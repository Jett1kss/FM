using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FM
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EquationPage : ContentPage
    {
        public EquationPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            double aD = 0;
            double bD = 0;
            double cD = 0;

            bool aB = double.TryParse(a.Text, out aD);
            bool bB = double.TryParse(b.Text, out bD);
            bool cB = double.TryParse(c.Text, out cD);

            if (a.Text == null || a.Text == "")
            {
                aD = 1;
                aB = true;
            }
            if (b.Text == null || b.Text == "")
            {
                bD = 1;
                bB = true;
            }
            if (c.Text == null || c.Text == "")
            {
                cD = 1;
                cB = true;
            }

            if (a.Text == "-")
            {
                aD = -1;
                aB = true;
            }
            if (b.Text == "-")
            {
                bD = -1;
                bB = true;
            }
            if (c.Text == "-")
            {
                cD = -1;
                cB = true;
            }

            if (!aB || !bB || !cB)
            {
                Label0.Text = "Ошибка!";
                Label0.TextColor = Color.Red;
                Label1.Text = "";
                Label2.Text = "";
                Label3.Text = "";
                Label4.Text = "";
            }
            else
            {
                Label0.Text = "Решение:";
                Label0.TextColor = new Color(0.25, 0.25, 0.25);


                if (aD == 0)
                {
                    if (bD == 0)
                    {
                        Label1.Text = $"{cD} = 0";


                        if (cD == 0)
                        {
                            Label2.Text = "x ∊ R";
                        }
                        else
                        {
                            Label2.Text = "x ∊ ∅";
                        }


                        Label3.Text = "";


                        Label4.Text = "";
                    }
                    else
                    {
                        Label1.Text = $"{bD}x + ";

                        if (cD >= 0)
                        {
                            Label1.Text += $"{cD} = 0";
                        }
                        else
                        {
                            Label1.Text += $"({cD}) = 0";
                        }


                        Label2.Text = $"{bD}x = -";

                        if (cD >= 0)
                        {
                            Label2.Text += $"{cD}";
                        }
                        else
                        {
                            Label2.Text += $"({cD})";
                        }


                        if (cD >= 0)
                        {
                            Label3.Text = $"x = -{cD}/{bD}";
                        }
                        else
                        {
                            Label3.Text = $"x = {Math.Abs(cD)}/{bD}";
                        }


                        Label4.Text = $"x ≈ {-cD / bD}";
                    }
                }
                else
                {
                    double D = Math.Pow(bD, 2) - 4 * aD * cD;

                    Label1.Text = $"D = ";

                    if (bD >= 0)
                    {
                        Label1.Text += $"{bD}^2 - 4 * ";
                    }
                    else
                    {
                        Label1.Text += $"({bD})^2 - 4 * ";
                    }

                    if (aD >= 0)
                    {
                        Label1.Text += $"{aD} * ";
                    }
                    else
                    {
                        Label1.Text += $"({aD}) * ";
                    }

                    if (cD >= 0)
                    {
                        Label1.Text += $"{cD} = ";
                    }
                    else
                    {
                        Label1.Text += $"({cD}) = ";
                    }

                    Label1.Text += $"{D}; ";


                    if (D >= 0)
                    {
                        Label1.Text += "D >= 0";


                        if (bD > 0)
                        {
                            Label2.Text = $"x1, x2 = (-{bD} ± √{D})/(2 * ";

                            if (aD >= 0)
                            {
                                Label2.Text += $"{aD})";
                            }
                            else
                            {
                                Label2.Text += $"({aD}))";
                            }
                        }
                        else
                        {
                            Label2.Text = $"x1, x2 = ({bD * -1} ± √{D})/(2 * ";

                            if (aD >= 0)
                            {
                                Label2.Text += $"{aD})";
                            }
                            else
                            {
                                Label2.Text += $"({aD}))";
                            }
                        }


                        double x1 = (-bD + Math.Sqrt(D)) / (2 * aD);
                        double x2 = (-bD - Math.Sqrt(D)) / (2 * aD);

                        Label3.Text = $"x1 ≈ {x1}";
                        Label4.Text = $"x2 ≈ {x2}";
                    }
                    else
                    {
                        Label1.Text += "D < 0. Корней нет";


                        Label2.Text = "x1, x2 = -";


                        Label3.Text = "x1 = -";


                        Label4.Text = "x2 = -";
                    }
                }
            }
        }
    }
}