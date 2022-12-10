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

function BootstrapCDN()
{
    let StdOut = document.getElementById("StdOut");
    StdOut.innerText = "";
    StdOut.innerText += '<!-- CSS only -->' + '\r\n';
    StdOut.innerText += '<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-rbsA2VBKQhggwzxH7pPCaAqO46MgnOM80zW1RWuH61DGLwZJEdK2Kadq2F9CUG65" crossorigin="anonymous">' + '\r\n';
    StdOut.innerText += '<!-- JavaScript Bundle with Popper -->' + '\r\n';
    StdOut.innerText += '<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-kenU1KFdBIe4zVF0s0G1M5b4hcpxyD9F7jL+jjXkk+Q2h455rYXK/7HAuoJl+0I4" crossorigin="anonymous"></script>';


}
