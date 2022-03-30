<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WizardControllTemplate.aspx.cs" Inherits="FileUploadController.WizardControllTemplate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Wizard ID="Wizard1" runat="server" ActiveStepIndex="1">
                <FinishNavigationTemplate>
                    <asp:Button ID="FinishPreviousButton" runat="server" CausesValidation="False" CommandName="MovePrevious" Text="Previous" />
                    <asp:Button ID="FinishButton" runat="server" CommandName="MoveComplete" Text="Finish" />
                </FinishNavigationTemplate>
                <StartNavigationTemplate>
                    <asp:Button ID="StartNextButton" runat="server" CommandName="MoveNext" Text="Next"
                        OnClientClick="return confirm('Are You Sure You Want To Go To Next Step')" />
                </StartNavigationTemplate>
                <StepNavigationTemplate>
                    <asp:Button ID="StepPreviousButton"UseSubmitBehavior="false" runat="server" CausesValidation="False" CommandName="MovePrevious" Text="Previous" />
                    <asp:Button ID="StepNextButton" runat="server" CommandName="MoveNext" Text="Next" />
                </StepNavigationTemplate>
                <WizardSteps>
                    <asp:WizardStep ID="WizardStep1" runat="server" Title="Step 1">
                        <asp:TextBox ID="Step1TextBox" runat="server"></asp:TextBox>
                    </asp:WizardStep>
                    <asp:WizardStep ID="WizardStep2" runat="server" Title="Step 2">
                        <asp:TextBox ID="Step2TextBox" runat="server"></asp:TextBox>
                    </asp:WizardStep>
                    <asp:WizardStep ID="WizardStep3" runat="server" Title="Step 3">
                        <asp:TextBox ID="Step3TextBox" runat="server"></asp:TextBox>
                    </asp:WizardStep>
                </WizardSteps>
            </asp:Wizard>
        </div>
    </form>
</body>
</html>
