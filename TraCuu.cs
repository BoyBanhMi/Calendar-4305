 private void buttonGo_Click_1(object sender, EventArgs e)
        {
            if ((comboBoxMonth.Text == null) || (textBoxYear.Text == null))
            {
                MessageBox.Show("Năm hoặc tháng không chính xác");
            }
            else
            {
                try
                {
                    Int32 t = Convert.ToInt32(textBoxYear.Text);
                    if ((textBoxYear.Text != "0") || (t < 1))
                    {
                        //xoa cac control pannel
                        panel1.Controls.Clear();
                        Thread.CurrentThread.CurrentCulture = new CultureInfo(CurrentCulture);
                        //hien thi cac thang vua chon
                        labelMonth.Text = Application.CurrentCulture.DateTimeFormat.GetMonthName(Convert.ToInt32(comboBoxMonth.Text));
                         Thread.CurrentThread.CurrentCulture = new CultureInfo("en-us");
                        Int32 Dayz = DateTime.DaysInMonth(Convert.ToInt32(textBoxYear.Text), Convert.ToInt32(comboBoxMonth.Text));
                        CheckDay();
                        for (Int32 i = 1; i < Dayz + 1; i++)
                        {
                            ndayz += 1;
                            lblDayz = new Label();
                            lblDayz.Text = i.ToString();
                            lblDayz.BorderStyle = BorderStyle.Fixed3D;
                            Int32 mon = Convert.ToInt32(comboBoxMonth.Text);
                            Int32 year = Convert.ToInt32(textBoxYear.Text);
                            if ((i == DateTime.Now.Day) && (mon == DateTime.Now.Month) && (year == DateTime.Now.Year))
                            {
                                //
                                lblDayz.BackColor = Color.Pink;
                            }
                            else if (ndayz == 01)
                            {
                                lblDayz.BackColor = Color.Gainsboro;
                            }
                            else
                            {
                                //xet cac gia tri mau 
                                lblDayz.BackColor = Color.Gainsboro;
                            }
                            lblDayz.Font = label31.Font;
                            lblDayz.SetBounds(x, y, 37, 27);

                            x += 42;
                            if (ndayz == 7)
                            {
                                x = 0;
                                ndayz = 0;
                                y += 29;
                            }
                            panel1.Controls.Add(lblDayz);
                        }
                        x = 0;
                        ndayz = 0;
                        y = 0;
                    }
                    else
                    {
                        MessageBox.Show("Năm phải từ 0 đến 9999");
                        textBoxYear.Focus();
                    }
                }
                catch (FormatException )
                {
                    MessageBox.Show("Năm phải từ 0 đến 9999");
                    textBoxYear.Focus();
                }
            }
        }
