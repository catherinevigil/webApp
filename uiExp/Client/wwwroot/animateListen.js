

//function initializeAnimateInListener() {
//    document.addEventListener('aos:in:convo-block', ({ detail }) => {
//        var d = new Date();
//        //console.log('animated in' + d.getSeconds(), detail);

//        });
//}

//function initializeAnimateOutListener() {
//    document.addEventListener('aos:out', ({ detail }) => {
//        var d = new Date();
//       // console.log('animated out' + d.getSeconds(), detail);
//    });
//}

var funcInit = function () {
    console.log("dom content loaded");
    // user code goes here and can safely address all the HTML elements from the page
    // since the document has successfully been 'loaded'

    function initializeAnimateInListener() {
        document.addEventListener('aos:in:convo-block', ({ detail }) => {
            var d = new Date();
            console.log('animated in' + d.getSeconds(), detail);

        });
        console.log("add int listener to doc");
    }

    function initializeAnimateOutListener() {
        document.addEventListener('aos:out', ({ detail }) => {
            var d = new Date();
            console.log('animated out' + d.getSeconds(), detail);
        });
        console.log("add out listener to doc");
    }

    initializeAnimateOutListener();
    initializeAnimateInListener();
}
document.addEventListener('DOMContentLoaded', funcInit);