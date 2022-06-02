using System.Collections.ObjectModel;

namespace IMAD_Logical_Model;

public partial class MainPage : ContentPage
{
	public MainPage()
    {
        InitializeComponent();
	}

    void ChangeColor(object sender, EventArgs args)
    {

        try
        {
            Button button = (Button)sender;

            if (button.Text == "Active")
            {
                button.SetDynamicResource(BackgroundColorProperty, "Inactive");
                button.Text = "Inactive";
            }
            else
            {
                button.SetDynamicResource(BackgroundColorProperty, "Active");
                button.Text = "Active";
            }
        }
        catch (InvalidCastException e)
        {

        }

        if (operatorPicker.SelectedItem == null)
            return;

        string selectedOperator = operatorPicker.SelectedItem.ToString();

        if (selectedOperator == "AND")
            resultLabel.Text = (leftButton.Text == "Active" && rightButton.Text == "Active").ToString();
        else if (selectedOperator == "OR")
            resultLabel.Text = (leftButton.Text == "Active" || rightButton.Text == "Active").ToString();
        else if (selectedOperator == "XOR")
            resultLabel.Text = (leftButton.Text == "Active" ^ rightButton.Text == "Active").ToString();

        if (resultLabel.Text == "True")
            resultLabel.SetDynamicResource(BackgroundColorProperty, "Active");
        else
            resultLabel.SetDynamicResource(BackgroundColorProperty, "Inactive");
    }
}

