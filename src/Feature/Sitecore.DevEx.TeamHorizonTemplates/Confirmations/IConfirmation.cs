namespace Sitecore.DevEx.TeamHorizonTemplates.Confirmations
{
    internal interface IConfirmation
    {
        ConfirmationResult YesNoMessage(
          string message,
          string yesMessage = null,
          string noMessage = null);
    }
}
