function InitializeTopPage() {
    document.getElementById("CommandTextbox").focus();
}



function GmailSearch(searchStr)
{
    let url = "https://mail.google.com/mail/mu/mp/122/#tl/search/" + searchStr;
    window.open(url, '_blank');

    
}

function GmailNew() {

    let url = "https://mail.google.com/mail/?view=cm&fs=1"
    window.open(url, '_blank');

}