
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
    //check if doc element is focused
    docElement.focus();
}

function initializeFocusListener(docElement) {
    docElement.addEventListener('focus', (event) => {
        event.target.style.background = 'pink';
    });
}


