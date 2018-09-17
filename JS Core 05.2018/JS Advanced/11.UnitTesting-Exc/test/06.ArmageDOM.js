const expect = require('chai').expect;
let jsdom = require('jsdom-global')();
let $ = require('jquery');

function nuke(selector1, selector2) {
    if (selector1 === selector2) return;
    $(selector1).filter(selector2).remove();
}

describe("nuke function", function () {
    beforeEach(function () {
        document.body.innerHTML = `
<div id="target">
    <div class="nested target">
        <p>This is some text</p>
    </div>
    <div class="target">
        <p>Empty div</p>
    </div>
    <div class="inside">
        <span class="nested">Some more text</span>
        <span class="target">Some more text</span>
    </div>
</div>`;
    });

    it("should not change the html if the selectors are equal",function () {
        nuke('p', 'p');
        expect(document.body.innerHTML).to.be.equal(`
<div id="target">
    <div class="nested target">
        <p>This is some text</p>
    </div>
    <div class="target">
        <p>Empty div</p>
    </div>
    <div class="inside">
        <span class="nested">Some more text</span>
        <span class="target">Some more text</span>
    </div>
</div>`)
    });

    it("nuke('div', '.inside') should remove div.inside",function () {
        nuke('div', '.inside');
        expect(document.body.innerHTML).to.be.equal(`
<div id="target">
    <div class="nested target">
        <p>This is some text</p>
    </div>
    <div class="target">
        <p>Empty div</p>
    </div>
    
</div>`)
    });

    it("nuke('div', '.inside') should remove div.inside",function () {
        nuke('div', '.nested');
        expect(document.body.innerHTML).to.be.equal(`
<div id="target">
    
    <div class="target">
        <p>Empty div</p>
    </div>
    <div class="inside">
        <span class="nested">Some more text</span>
        <span class="target">Some more text</span>
    </div>
</div>`)
    });
});

