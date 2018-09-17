function trackBug() {
    let counter = 0;
    let selector = '';

    return {
        bugs: [],
        report: function (author, description, reproducible, severity) {
            let bug = {};
            bug.ID = counter;
            counter++;
            bug.author = author;
            bug.description = description;
            bug.reproducible = reproducible;
            bug.severity = severity;
            bug.status = 'Open';
            this.bugs.push(bug);

            if (selector) {
                this.print();
            }
        },

        setStatus: function (id, newStatus) {
            let bug = this.bugs.filter(x => x.ID === id);
            bug = bug[0];
            bug.status = newStatus;

            if (selector) {
                this.print();
            }
        },

        remove: function (id) {
            this.bugs.splice(id, 1);

            if (selector) {
                this.print();
            }
        },

        sort: function (method) {
            switch (method) {
                case 'author':
                    this.bugs.sort((a, b) => a.author.localeCompare(b.author));
                    break;
                case 'severity':
                    this.bugs.sort((a, b) => a.severity - b.severity);
                    break;
                case 'ID':
                    this.bugs.sort((a, b) => a.ID - b.ID);
                    break;
                default:
                    break;
            }
            if (selector) {
                this.print();
            }
        },

        output: function (sel) {
            selector = sel;
        },

        print: function () {
            $(selector).html("");
            for (const bug of this.bugs) {
                let html = `<div id="report_${bug.ID}" class="report">
  <div class="body">
    <p>${bug.description}</p>
  </div>
  <div class="title">
    <span class="author">Submitted by: ${bug.author}</span>
    <span class="status">${bug.status} | ${bug.severity}</span>
  </div>
</div>`;
                $(selector).append(html);
            }
        }
    }
}

// let tracker = trackBug();
// tracker.report('guy', 'report content', true, 5);
// tracker.report('second guy', 'report content 2', true, 3);
// tracker.report('abv', 'report content three', true, 4);
// tracker.output('#content');
// console.log(tracker);