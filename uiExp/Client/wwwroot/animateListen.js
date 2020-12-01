


function initializeAnimateInListener() {
    document.addEventListener('aos:in:convo-block', ({ detail }) => {
        var d = new Date();
        console.log('animated in' + d.getSeconds(), detail);

        });
}

function initializeAnimateOutListener() {
    document.addEventListener('aos:out', ({ detail }) => {
        var d = new Date();
       // console.log('animated out' + d.getSeconds(), detail);
    });
}