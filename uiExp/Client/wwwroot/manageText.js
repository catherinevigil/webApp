
function resizeText(docElement) {
    //const inputTextArea = document.getElementById("inputTextArea");
    //inputTextArea.style.height = 'auto';
    //inputTextArea.style.height = (inputTextArea.scrollHeight) + 'px';
    //return inputTextArea.scrollHeight;

    docElement.style.height = 'auto';
    docElement.style.height = (docElement.scrollHeight) + 'px';
    return docElement.scrollHeight;

}


function focused(docElement) {
    //check if doc element is focused
    return (document.activeElement === docElement);
}

function focus(docElement) {
    docElement.focus();
}
function Block(keyboardEvent) {

    keyboardEvent.preventDefault();
}

function focusUndo(element, keyboardEvent) {
    element.focus();
    document.execCommand("undo");
}

function initializeFocusListener(docElement) {
    docElement.addEventListener('focus', (event) => {
       // event.target.style.background = 'pink';
    });
}

function pDefault(event) {
    console.log("will attempt to prevent default");
    event.preventDefault();
   // document.execCommand("undo");  
}


//function initOninputListener(docElement) {
//    console.log("initialize event listener");
//    docElement.addEventListener('input', (event) => {
//        if (event.keyCode == 13) {
//            document.execCommand("undo");
//            console.log("heard enter press");
//        }
            
            
//        console.log("input event");
//        console.log("event key code" + event.keyCode);
//    });
//}

function focusSlow(element) {
    console.log("slowly focusing");
    setTimeout(element.focus(), 10000);
}

function initKeypressListener(docElement) {
    console.log("initialize event listener");
    docElement.addEventListener('keypress', (event) => {
        if (event.keyCode == 13) {
            //document.execCommand("undo");
            event.preventDefault();
            console.log("heard enter press");
        }


        console.log("input event");
        console.log("event key code" + event.keyCode);
    });
}


//function clearContents(element) {
//    var rows = element.value.split('\n');
//    console.log("rows length: " + rows.length);

//    console.log("about to clear contents... ");
//    element.value = element.value.replace(/(\r\n|\n|\r)/gm, "")
//}