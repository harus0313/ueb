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

function TwitterNew()
{
    let url = "https://twitter.com/intent/tweet";
    window.open(url, '_blank');
}

function RakutenSearch(keyword)
{
    let url = "https://search.rakuten.co.jp/search/mall/" + keyword + "/";
    window.open(url, '_blank');
}

function BootstrapDocs() {
    let url = "https://getbootstrap.com/docs/5.2/getting-started/introduction/";
    window.open(url, '_blank');
}


