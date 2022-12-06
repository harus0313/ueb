function InitializeTopPage() {
    document.getElementById("CommandTextbox").focus();
}



function GmailSearch(searchStr)
{
    let url = "https://mail.google.com/mail/mu/mp/122/#tl/search/" + searchStr;
    console.log(url);
    window.open(url, '_blank');

    
}