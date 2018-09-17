class TitleBar {
    constructor(title) {
        this.title = title;
        this.links = [];
    }

    addLink(href, name) {
        this.links.push({'href': href, 'name': name});
    }

    appendTo(selector) {
        let menu = $('<header class="header">');
        let headerRow = $('<div class="header-row">');
        let toggleBtn = $('<a class="button">&#9776;</a>').on('click', function () {
            $('.drawer').toggle();
        });
        headerRow.append(toggleBtn)
            .append(`<span class="title">${this.title}</span>`);
        let drawerDiv = $('<div class="drawer">');
        let nav = $('<nav class="menu">');
        for (const link of this.links) {
            nav.append(`<a class="menu-link" href="${link.href}">${link.name}</a>`)
        }
        drawerDiv.append(nav);
        menu.append(headerRow)
            .append(drawerDiv);
        $(selector).prepend(menu);
    }
}