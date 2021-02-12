
	public CheckNumber(string input)
    {
    int code;
    if (input, out code)
    {
        if (NameDataBase.NameTbl.ToList().Any(a => a.Codeint == code))
        {
            sb.AppendLine("کد وارد شده یکی از سطر ها تکراری است لطفا بعدا آن را تصحیح کنید.");
            Class.Message.ShowError(sb.ToString());

            break;
        }
        else
        {
            giftCard.Codeint = code;
            giftCard.code = null;
        }
    }
    else
    {
        if (NameDataBase.NameTbl.ToList().Any(a => a.code == Set_String_Size(gv.Rows[i].Cells[0].Value, 255)))
        {
            sb.AppendLine("کد وارد شده یکی از سطر ها تکراری است لطفا بعدا آن را تصحیح کنید.");
            Class.Message.ShowError(sb.ToString());

            break;
        }
        else
        {
            Variable.code = Set_String_Size(gv.Rows[i].Cells[0].Value, 255);
            Variable.Codeint = null;
        }
    }
    }

    //چک تاریخ
    public CheckDate(string input)
    {
    DateTime dt;

    string format = "yyyy-dd-MM";

        if (input != null)
        {
            if (input, out dt)
            {
                Variable.Exptime = Set_String_Size(gv.Rows[i].Cells["Exptime"].Value, 255);
            }
        else
        {
            sb.AppendLine("تاریخ وارد شده یکی از سطر ها اشتباه است لطفا بعدا آن را تصحیح کنید.");
            Class.Message.ShowError(sb.ToString());
            Variable.Exptime = null;
        }
    }
    }
    

