//(function (window, document) {

//    // we fetch the elements each time because docusaurus removes the previous
//    // element references on page navigation
//    function getElements() {
//        return {
//            layout: document.getElementById('layout'),
//            menu: document.getElementById('menu'),
//            menuLink: document.getElementById('menuLink')
//        };
//    }

//    function toggleClass(element, className) {
//        var classes = element.className.split(/\s+/);
//        var length = classes.length;
//        var i = 0;

//        for (; i < length; i++) {
//            if (classes[i] === className) {
//                classes.splice(i, 1);
//                break;
//            }
//        }
//        // The className is not found
//        if (length === classes.length) {
//            classes.push(className);
//        }

//        element.className = classes.join(' ');
//    }

//    function toggleAll() {
//        var active = 'active';
//        var elements = getElements();

//        toggleClass(elements.layout, active);
//        toggleClass(elements.menu, active);
//        toggleClass(elements.menuLink, active);
//    }

//    function handleEvent(e) {
//        var elements = getElements();

//        if (e.target.id === elements.menuLink.id) {
//            toggleAll();
//            e.preventDefault();
//        } else if (elements.menu.className.indexOf('active') !== -1) {
//            toggleAll();
//        }
//    }

//    document.addEventListener('click', handleEvent);

//}(this, this.document));




document.addEventListener("DOMContentLoaded", function (event) {

    const showNavbar = (toggleId, navId, bodyId, headerId) => {
        const toggle = document.getElementById(toggleId),
            nav = document.getElementById(navId),
            bodypd = document.getElementById(bodyId),
            headerpd = document.getElementById(headerId)

        // Validate that all variables exist
        if (toggle && nav && bodypd && headerpd) {
            toggle.addEventListener('click', () => {
                // show navbar
                nav.classList.toggle('show')
                // change icon
                toggle.classList.toggle('bx-x')
                // add padding to body
                bodypd.classList.toggle('body-pd')
                // add padding to header
                headerpd.classList.toggle('body-pd')
            })
        }
    }

    showNavbar('header-toggle', 'nav-bar', 'body-pd', 'header')

    /*===== LINK ACTIVE =====*/
    const linkColor = document.querySelectorAll('.nav_link')

    function colorLink() {
        if (linkColor) {
            linkColor.forEach(l => l.classList.remove('active'))
            this.classList.add('active')
        }
    }
    linkColor.forEach(l => l.addEventListener('click', colorLink))

    // Your code to run since DOM is loaded and ready
});