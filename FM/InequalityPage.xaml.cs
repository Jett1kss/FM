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
    public partial class InequalityPage : ContentPage
    {
        public InequalityPage()
        {
            InitializeComponent();

            p.Items.Add(">");
            p.Items.Add("<");
            p.Items.Add("≥");
            p.Items.Add("≤");
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (p.SelectedItem == null)
            {
                Label0.Text = "Выберите знак сравнения!";
                Label0.TextColor = Color.Red;
                Label1.Text = "";
                Label2.Text = "";
                Label3.Text = "";
                Label4.Text = "";
                Label5.Text = "";
                Image0.Source = "";
                Label6.Text = "";
                return;
            }


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
                Label5.Text = "";
                Image0.Source = "";
                Label6.Text = "";
            }
            else
            {
                Label0.Text = "Решение:";
                Label0.TextColor = new Color(0.25, 0.25, 0.25);


                if (aD == 0)
                {
                    if (bD == 0)
                    {
                        Label1.Text = $"{cD} " + p.SelectedItem.ToString() + " 0";


                        if (p.SelectedItem.ToString() == ">")
                        {
                            if (cD > 0)
                            {
                                Label2.Text = "x ∊ R";
                            }
                            else
                            {
                                Label2.Text = "x ∊ ∅";
                            }
                            
                        }
                        else if (p.SelectedItem.ToString() == "<")
                        {
                            if (cD < 0)
                            {
                                Label2.Text = "x ∊ R";
                            }
                            else
                            {
                                Label2.Text = "x ∊ ∅";
                            }
                        }
                        else if (p.SelectedItem.ToString() == "≥")
                        {
                            if (cD >= 0)
                            {
                                Label2.Text = "x ∊ R";
                            }
                            else
                            {
                                Label2.Text = "x ∊ ∅";
                            }
                        }
                        else
                        {
                            if (cD <= 0)
                            {
                                Label2.Text = "x ∊ R";
                            }
                            else
                            {
                                Label2.Text = "x ∊ ∅";
                            }
                        }

                        Label3.Text = "";


                        Label4.Text = "";


                        Label5.Text = "";


                        Image0.IsVisible = false;


                        Label6.Text = "";
                    }
                    else
                    {
                        Label1.Text = $"{bD}x + ";

                        if (cD >= 0)
                        {
                            Label1.Text += $"{cD} ";
                        }
                        else
                        {
                            Label1.Text += $"({cD}) ";
                        }

                        Label1.Text += p.SelectedItem.ToString() + " 0";


                        Label2.Text = $"{bD}x " + p.SelectedItem.ToString() + " -";

                        if (cD >= 0)
                        {
                            Label2.Text += $"{cD}";
                        }
                        else
                        {
                            Label2.Text += $"({cD})";
                        }


                        Label3.Text = "x ";

                        if (p.SelectedItem.ToString() == ">")
                        {
                            if (bD > 0)
                            {
                                Label3.Text += $"> ";

                                if (cD >= 0)
                                {
                                    Label3.Text += $"-{cD}/{bD}";
                                }
                                else
                                {
                                    Label3.Text += $"{Math.Abs(cD)}/{bD}";
                                }

                                Label4.Text = $"x ∊ ({-cD / bD}; +∞). x > {-cD / bD}";
                            }
                            else
                            {
                                Label3.Text += $"< ";

                                if (cD >= 0)
                                {
                                    Label3.Text += $"-{cD}/{bD}";
                                }
                                else
                                {
                                    Label3.Text += $"{Math.Abs(cD)}/{bD}";
                                }

                                Label4.Text = $"x ∊ (-∞; {-cD / bD}). x < {-cD / bD}";
                            }
                        }
                        else if (p.SelectedItem.ToString() == "<")
                        {
                            if (bD > 0)
                            {
                                Label3.Text += $"< ";

                                if (cD >= 0)
                                {
                                    Label3.Text += $"-{cD}/{bD}";
                                }
                                else
                                {
                                    Label3.Text += $"{Math.Abs(cD)}/{bD}";
                                }

                                Label4.Text = $"x ∊ (-∞; {-cD / bD}). x < {-cD / bD}";
                            }
                            else
                            {
                                Label3.Text += $"> ";

                                if (cD >= 0)
                                {
                                    Label3.Text += $"-{cD}/{bD}";
                                }
                                else
                                {
                                    Label3.Text += $"{Math.Abs(cD)}/{bD}";
                                }

                                Label4.Text = $"x ∊ ({-cD / bD}; +∞). x > {-cD / bD}";
                            }
                        }
                        else if (p.SelectedItem.ToString() == "≥")
                        {
                            if (bD > 0)
                            {
                                Label3.Text += $"≥ ";

                                if (cD >= 0)
                                {
                                    Label3.Text += $"-{cD}/{bD}";
                                }
                                else
                                {
                                    Label3.Text += $"{Math.Abs(cD)}/{bD}";
                                }

                                Label4.Text = $"x ∊ [{-cD / bD}; +∞). x ≥ {-cD / bD}";
                            }
                            else
                            {
                                Label3.Text += $"≤ ";

                                if (cD >= 0)
                                {
                                    Label3.Text += $"-{cD}/{bD}";
                                }
                                else
                                {
                                    Label3.Text += $"{Math.Abs(cD)}/{bD}";
                                }

                                Label4.Text = $"x ∊ (-∞; {-cD / bD}]. x ≤ {-cD / bD}";
                            }
                        }
                        else
                        {
                            if (bD > 0)
                            {
                                Label3.Text += $"≤ ";

                                if (cD >= 0)
                                {
                                    Label3.Text += $"-{cD}/{bD}";
                                }
                                else
                                {
                                    Label3.Text += $"{Math.Abs(cD)}/{bD}";
                                }

                                Label4.Text = $"x ∊ (-∞; {-cD / bD}]. x ≤ {-cD / bD}";
                            }
                            else
                            {
                                Label3.Text += $"≥ ";

                                if (cD >= 0)
                                {
                                    Label3.Text += $"-{cD}/{bD}";
                                }
                                else
                                {
                                    Label3.Text += $"{Math.Abs(cD)}/{bD}";
                                }

                                Label4.Text = $"x ∊ [{-cD / bD}; +∞). x ≥ {-cD / bD}";
                            }
                        }


                        Label5.Text = "";


                        Image0.IsVisible = false;


                        Label6.Text = "";
                    }
                }
                else
                {
                    if (aD >= 0)
                    {
                        Label1.Text = $"{aD} * x^2 + ";
                    }
                    else
                    {
                        Label1.Text = $"({aD}) * x^2 + ";
                    }

                    if (bD >= 0)
                    {
                        Label1.Text += $"{bD} * x + ";
                    }
                    else
                    {
                        Label1.Text += $"({bD}) * x + ";
                    }

                    if (cD >= 0)
                    {
                        Label1.Text += $"{cD} = 0";
                    }
                    else
                    {
                        Label1.Text += $"({cD}) = 0";
                    }


                    double D = Math.Pow(bD, 2) - 4 * aD * cD;

                    Label2.Text = $"D = ";

                    if (bD >= 0)
                    {
                        Label2.Text += $"{bD}^2 - 4 * ";
                    }
                    else
                    {
                        Label2.Text += $"({bD})^2 - 4 * ";
                    }

                    if (aD >= 0)
                    {
                        Label2.Text += $"{aD} * ";
                    }
                    else
                    {
                        Label2.Text += $"({aD}) * ";
                    }

                    if (cD >= 0)
                    {
                        Label2.Text += $"{cD} = ";
                    }
                    else
                    {
                        Label2.Text += $"({cD}) = ";
                    }

                    Label2.Text += $"{D}; ";

                    if (D > 0)
                    {
                        Label2.Text += "D > 0";


                        if (bD > 0)
                        {
                            Label3.Text = $"x1, x2 = (-{bD} ± √{D})/(2 * ";

                            if (aD >= 0)
                            {
                                Label3.Text += $"{aD})";
                            }
                            else
                            {
                                Label3.Text += $"({aD}))";
                            }
                        }
                        else
                        {
                            Label3.Text = $"x1, x2 = ({bD * -1} ± √{D})/(2 * ";

                            if (aD >= 0)
                            {
                                Label3.Text += $"{aD})";
                            }
                            else
                            {
                                Label3.Text += $"({aD}))";
                            }
                        }


                        double x1_ = (-bD + Math.Sqrt(D)) / (2 * aD);
                        double x2_ = (-bD - Math.Sqrt(D)) / (2 * aD);
                        double x1 = Math.Min(x1_, x2_);
                        double x2 = Math.Max(x1_, x2_);

                        Label4.Text = $"x1 ≈ {x1}";
                        Label5.Text = $"x2 ≈ {x2}";


                        string Path = "Arrow_2_";
                        if (p.SelectedItem.ToString() == ">" || p.SelectedItem.ToString() == "<")
                        {
                            Path += "0_";
                        }
                        else
                        {
                            Path += "1_";
                        }
                        double x = (x1 + x2) / 2;

                        bool firstVal = false;

                        if ((aD * Math.Pow(x, 2) + bD * x + cD) > 0)
                        {
                            Path += "minusplusminus.png";

                            firstVal = true;
                        }
                        else
                        {
                            Path += "plusminusplus.png";

                            firstVal = false;
                        }

                        Image0.IsVisible = true;
                        Image0.Source = Path;


                        Label6.Text = $"x ∊ ";
                        if (p.SelectedItem.ToString() == ">")
                        {
                            if (firstVal)
                            {
                                Label6.Text += $"({Math.Min(x1, x2)}; {Math.Max(x1, x2)}). {Math.Min(x1, x2)} < x < {Math.Max(x1, x2)}";
                            }
                            else
                            {
                                Label6.Text += $"(-∞; {Math.Min(x1, x2)}) ∪ ({Math.Max(x1, x2)}; +∞). x ∊ R \\ [{Math.Min(x1, x2)}; {Math.Max(x1, x2)}]";
                            }
                        }
                        else if (p.SelectedItem.ToString() == "<")
                        {
                            if (firstVal)
                            {
                                Label6.Text += $"(-∞; {Math.Min(x1, x2)}) ∪ ({Math.Max(x1, x2)}; +∞). x ∊ R \\ [{Math.Min(x1, x2)}; {Math.Max(x1, x2)}]";
                            }
                            else
                            {
                                Label6.Text += $"({Math.Min(x1, x2)}; {Math.Max(x1, x2)}). {Math.Min(x1, x2)} < x < {Math.Max(x1, x2)}";
                            }
                        }
                        else if (p.SelectedItem.ToString() == "≥")
                        {
                            if (firstVal)
                            {
                                Label6.Text += $"[{Math.Min(x1, x2)}; {Math.Max(x1, x2)}]. {Math.Min(x1, x2)} ≤ x ≤ {Math.Max(x1, x2)}";
                            }
                            else
                            {
                                Label6.Text += $"(-∞; {Math.Min(x1, x2)}] ∪ [{Math.Max(x1, x2)}; +∞). x ∊ R \\ ({Math.Min(x1, x2)}; {Math.Max(x1, x2)})";
                            }
                        }
                        else
                        {
                            if (firstVal)
                            {
                                Label6.Text += $"(-∞; {Math.Min(x1, x2)}] ∪ [{Math.Max(x1, x2)}; +∞). x ∊ R \\ ({Math.Min(x1, x2)}; {Math.Max(x1, x2)})";
                            }
                            else
                            {
                                Label6.Text += $"[{Math.Min(x1, x2)}; {Math.Max(x1, x2)}]. {Math.Min(x1, x2)} ≤ x ≤ {Math.Max(x1, x2)}";
                            }
                        }
                    }
                    else if (D == 0)
                    {
                        Label2.Text += "D = 0.";


                        if (bD > 0)
                        {
                            Label3.Text = $"x1, x2 = (-{bD} ± √{D})/(2 * ";

                            if (aD >= 0)
                            {
                                Label3.Text += $"{aD})";
                            }
                            else
                            {
                                Label3.Text += $"({aD}))";
                            }
                        }
                        else
                        {
                            Label3.Text = $"x1, x2 = ({bD * -1} ± √{D})/(2 * ";

                            if (aD >= 0)
                            {
                                Label3.Text += $"{aD})";
                            }
                            else
                            {
                                Label3.Text += $"({aD}))";
                            }
                        }


                        double x = (-bD) / (2 * aD);

                        Label4.Text = $"x1 ≈ {x}";
                        Label5.Text = $"x2 ≈ {x}";


                        string Path = "Arrow_1_";
                        if (p.SelectedItem.ToString() == ">" || p.SelectedItem.ToString() == "<")
                        {
                            Path += "0_";
                        }
                        else
                        {
                            Path += "1_";
                        }

                        bool firstVal = false;

                        if ((aD * Math.Pow(x + 1, 2) + bD * (x + 1) + cD) > 0)
                        {
                            Path += "plusplus.png";

                            firstVal = false;
                        }
                        else
                        {
                            Path += "minusminus.png";

                            firstVal = true;
                        }

                        Image0.Source = Path;


                        Label6.Text = "x ∊ ";
                        if (p.SelectedItem.ToString() == ">")
                        {
                            if (firstVal)
                            {
                                Label6.Text += $"∅";
                            }
                            else
                            {
                                Label6.Text += $"(-∞; {x}) ∪ ({x}; ∞). x ∊ R \\ {{{x}}}";
                            }
                        }
                        else if (p.SelectedItem.ToString() == "<")
                        {
                            if (firstVal)
                            {
                                Label6.Text += $"(-∞; {x}) ∪ ({x}; ∞). x ∊ R \\ {{{x}}}";
                            }
                            else
                            {
                                Label6.Text += $"∅";
                            }
                        }
                        else if (p.SelectedItem.ToString() == "≥")
                        {
                            if (firstVal)
                            {
                                Label6.Text += $"{{{x}}}. x = {x}";
                            }
                            else
                            {
                                Label6.Text += "R";
                            }
                        }
                        else
                        {
                            if (firstVal)
                            {
                                Label6.Text += "R";
                            }
                            else
                            {
                                Label6.Text += $"{{{x}}}. x = {x}";
                            }
                        }
                    }
                    else
                    {
                        Label2.Text += "D < 0. Знак функции постоянный";


                        Label3.Text = "x1, x2 = -";


                        Label4.Text = "x1 = -";


                        Label5.Text = "x2 = -";


                        string Path = "Arrow_";

                        bool firstVal = false;

                        if (cD > 0)
                        {
                            Path += "plus.png";

                            firstVal = false;
                        }
                        else
                        {
                            Path += "minus.png";

                            firstVal = true;
                        }

                        Image0.Source = Path;


                        Label6.Text = "x ∊ ";
                        if (p.SelectedItem.ToString() == ">" || p.SelectedItem.ToString() == "≥")
                        {
                            if (firstVal)
                            {
                                Label6.Text += "∅";
                            }
                            else
                            {
                                Label6.Text += "R";
                            }
                        }
                        else
                        {
                            if (firstVal)
                            {
                                Label6.Text += "R";
                            }
                            else
                            {
                                Label6.Text += "∅";
                            }
                        }
                    }
                }
            }
        }
    }
}