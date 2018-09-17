class LineManager {
    constructor(stops) {
        this.stops = stops;
        this.currentStop = 0;
        this.timeOnCourse = 0;
        this.currentTimeNeeded = 0;
        this._currentDelay = 0;
    }

    set stops(arr) {
        for (const stop of arr) {
            if (typeof stop['name'] !== 'string' || stop['name'] === '') {
                throw new Error('Name should be a non empty string!')
            }

            if (typeof stop.timeToNext !== "number" || stop.timeToNext < 0) {
                throw new Error('Time should be a positive number!')
            }
        }

        this._stops = arr;
    }

    get atDepot() {
        return this.currentStop === this._stops.length - 1;
    }

    get nextStopName() {
        if (this.atDepot) {
            return 'At depot.';
        }
        return `${this._stops[this.currentStop + 1].name}`;
    }

    get currentDelay() {
        return this._currentDelay;
    }

    arriveAtStop(minutes) {
        if (minutes < 0) {
            throw new Error('Invalid minutes!');
        }
        if (this.atDepot) {
            throw new Error('The bus is at the depot!')
        }

        this.currentTimeNeeded += this._stops[this.currentStop].timeToNext;
        this.timeOnCourse += minutes;
        this._currentDelay = this.timeOnCourse - this.currentTimeNeeded;
        this.currentStop++;

        return !this.atDepot;
    }

    toString() {
        let result = `Line summary\n`;

        if (this.atDepot) {
            result += `- Course completed\n`;
        } else {
            result += `- Next stop: ${this.nextStopName}\n`;
        }

        result += `- Stops covered: ${this.currentStop}\n`;
        result += `- Time on course: ${this.timeOnCourse} minutes\n`;
        result += `- Delay: ${this._currentDelay} minutes`;

        return result;
    }
}
