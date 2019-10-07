/*
 *  Ken Macneal
 *  10/5/2019
 *  Davinci College App
 *
 */ 

using System;
using System.Windows.Forms;
using OffCampusNamespace;
using OnCampusNamespace;
using StudentNamespace;

namespace DavinciCollegeV2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region formFunctions

        private void Form1_Load(object sender, EventArgs e)
        {
            grpHousing.Visible = false;
            chkAutomobile.Visible = false;
        }

        private void radCampus_CheckedChanged(object sender, EventArgs e)
        {
            if (radOnCampus.Checked)
            {
                grpHousing.Visible = true;
                chkAutomobile.Visible = false;
            }
        }

        private void radOffCampus_CheckChanged(object sender, EventArgs e)
        {
            if (radOffCampus.Checked)
            {
                grpHousing.Visible = false;
                chkAutomobile.Visible = true;
            }
        }

        private void btnExitApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFeeCalculation_Click(object sender, EventArgs e)
        {
            if (DataValidated() == true)
            {
                process();
            }
        }

        #endregion form Functions
        public void process()
        {
            errProvider.Clear();
            string name = txtSNameInput.Text;
            string sID = txtSIDInput.Text;
            int credits;

            if (DataValidated())
            {
                if (int.TryParse(txtSCreditInput.Text, out credits) == true && credits > 0)
                {
                    if (radOffCampus.Checked)
                    {
                        OffCampus offCampusStudent = new OffCampus(name, sID, credits, chkAutomobile.Checked);
                        rtbFeeOutput.Text = offCampusStudent.ToString();
                    }
                    else
                    {
                        HousingType chosenDorm = (radLondon.Checked) ? HousingType.London : radParis.Checked ? HousingType.Paris : HousingType.Rome;

                        OnCampus onCampusStudent = new OnCampus(name, sID, credits, chosenDorm);
                        rtbFeeOutput.Text = onCampusStudent.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Credit Input", "Credit");
                    errProvider.SetError(txtSCreditInput, "Invalid credit input");
                    txtSCreditInput.Focus();
                }
            }
        }

        //To Do: Need to finish the main field check and then
        //get the group box verifications done;
        #region general functions
        public bool DataValidated()
        {
            bool residenceNotChecked = !radOffCampus.Checked && !radOnCampus.Checked;
            bool housingNotChecked = !radParis.Checked && !radRome.Checked && !radLondon.Checked;

            if (txtSNameInput.Text == string.Empty)
            {
                errProvider.SetError(txtSNameInput, "Invalid name Input");
                txtSNameInput.Focus();
                return false;
            }
            else
            {
                if (txtSIDInput.Text == string.Empty)
                {
                    errProvider.SetError(txtSIDInput, "Invalid ID input");
                    txtSIDInput.Focus();
                    return false;
                }
                else
                {
                    if (txtSCreditInput.Text == string.Empty)
                    {
                        errProvider.SetError(txtSCreditInput, "Credit Input needed");
                        txtSCreditInput.Focus();
                        return false;
                    }
                    else
                    {
                        if (residenceNotChecked)
                        {
                            errProvider.SetError(grpResidence, "residence Not chosen");
                            return false;
                        }
                        else
                        {
                            if (radOnCampus.Checked)
                            {
                                if (housingNotChecked)
                                {
                                    errProvider.SetError(grpHousing, "Dorm not chosen");
                                    return false;
                                }
                                else
                                {
                                    return true;
                                }
                            }
                            else
                            {
                                return true;
                            }
                        }
                    }
                    //end if else statements
                }
                //end if statment
            }
            //end data validation method
        }

        #endregion general Functions


    }
}
