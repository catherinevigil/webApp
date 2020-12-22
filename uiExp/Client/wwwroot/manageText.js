
function resizeText(docElement) {
    //const inputTextArea = document.getElementById("inputTextArea");
    //inputTextArea.style.height = 'auto';
    //inputTextArea.style.height = (inputTextArea.scrollHeight) + 'px';
    //return inputTextArea.scrollHeight;

    docElement.style.height = 'auto';
    docElement.style.height = (docElement.scrollHeight) + 'px';
    return docElement.scrollHeight;

}