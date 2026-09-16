
private void OnCalculateClicked(object sender, EventArgs e)
{
    // 1. Read the input string from the entry text
    double bill = double.Parse(billEntry.Text);

    // 2. Perform your calculations (e.g., Option A)
    double tip = bill * 0.20;
    double total = bill + tip;

    // 3. Format and assign the output string to your label's Text property
    resultLabel.Text = $"Tip: {tip:C} | Total: {total:C}";
}