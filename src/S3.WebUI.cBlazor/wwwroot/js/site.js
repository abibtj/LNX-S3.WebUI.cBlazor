
$(document).ready(function () {

   

    downloadReportCards = function () {
        var pdf = new jsPDF('l', 'pt', 'a4');
        //pdf.setTextColor(255, 0, 0);
        // source can be HTML-formatted string, or a reference
        // to an actual DOM element from which the text will be scraped.
        var source = $('#all-report-cards')[0];
        //var source1 = $('#all-report-cards');
        //var source2 = document.getElementById('all-report-cards');
        //var source3 = document.getElementById('all-report-cards')[0];

        // we support special element handlers. Register them with jQuery-style 
        // ID selector for either ID or node name. ("#iAmID", "div", "span" etc.)
        // There is no support for any other type of selectors 
        // (class, of compound) at this time.
        //specialElementHandlers = {
        //    // element with id of "bypass" - jQuery style selector
        //    '#bypassme': function (element, renderer) {
        //        // true = "handled elsewhere, bypass text extraction"
        //        return true
        //    }
        //};
        margins = {
            top: 80,
            bottom: 60,
            left: 40,
            width: 600
        };
        // all coords and widths are in jsPDF instance's declared units
        // 'inches' in this case
        //pdf.fromHTML(
        //    source, // HTML string or DOM elem ref.
        //    margins.left, // x coord
        //    margins.top,
        //    { // y coord
        //        'width': margins.width // max width of content on PDF
        //        //'elementHandlers': specialElementHandlers
        //    },

        //    function (dispose) {
        //        // dispose: object with X, Y of the last line add to the PDF 
        //        //          this allow the insertion of new lines after html
        //        pdf.save('Report Cards.pdf');
        //    }, margins
        //);

        var doc = new jsPDF('l', 'pt', 'a4');
        doc.addHTML(document.getElementById('all-report-cards'), 200, 200, {}, function () {
            doc.save('test.pdf');
        });

        //var doc = new jsPDF()
        //doc.text(10, 10, $('.all-report-cards'))
        ////doc.autoPrint()
        //doc.save('test.pdf')

    }


    //downloadReportCards = function (filename, bytesBase64) {
    //    if (navigator.msSaveBlob) {
    //        //Download document in Edge browser
    //        var data = window.atob(bytesBase64);
    //        var bytes = new Uint8Array(data.length);
    //        for (var i = 0; i < data.length; i++) {
    //            bytes[i] = data.charCodeAt(i);
    //        }
    //        var blob = new Blob([bytes.buffer], { type: "application/octet-stream" });
    //        navigator.msSaveBlob(blob, filename);
    //    }
    //    else {
    //        var link = document.createElement('a');
    //        link.download = filename;
    //        link.href = "data:application/octet-stream;base64," + bytesBase64;
    //        document.body.appendChild(link); // Needed for Firefox
    //        link.click();
    //        document.body.removeChild(link);
    //    }
    //}


    //function printPreviewItem(idSelector) {
    //    //var restorePage = document.body.innerHTML;
    //    //var printContent = document.getElementById(idSelector).innerHTML;
    //    //document.body.innerHTML = printContent;
    //    //window.print();
    //    //document.body.innerHTML = restorePage;


    //    //var prtContent = document.getElementById(idSelector);
    //    //var WinPrint = window.open('', '', 'left=0,top=0,width=800,height=900,toolbar=0,scrollbars=0,status=0');
    //    //WinPrint.document.write(prtContent.innerHTML);
    //    //WinPrint.document.close();
    //    //WinPrint.focus();
    //    //WinPrint.print();
    //    //WinPrint.close();
    //}


});