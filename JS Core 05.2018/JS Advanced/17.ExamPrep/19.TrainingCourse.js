class TrainingCourse {
    constructor(title, trainer) {
        this.title = title;
        this.trainer = trainer;
        this.topics = [];
    }

    addTopic(title, date) {
        this.topics.push({'title': title, 'date': date});
        this.topics.sort((a, b) =>  a.date - b.date);
    }

    get firstTopic() {
        return this.topics[0];
    }

    get lastTopic() {
        return this.topics[this.topics.length - 1];
    }

    toString() {
        let result = `Course "${this.title}" by ${this.trainer}\n`;

        for (let i = 0; i < this.topics.length; i++) {
            result += ` * ${this.topics[i]['title']} - ${this.topics[i]['date']}\n`;

            if (i === this.topics.length - 1) {
                result = result.trim();
            }
        }

        return result;
    }
}