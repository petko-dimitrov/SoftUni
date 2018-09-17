let forumPost = {
    id: '1234',
    author: 'author name',
    content: 'these fields are irrelevant',
    upvotes: 132,
    downvotes: 68
};

function solution(input) {
    switch (input) {
        case 'upvote':
            this.upvotes++;
            break;
        case 'downvote':
            this.downvotes++;
            break;
        case 'score':
            let result = [];

            if (this.upvotes + this.downvotes > 50) {
                let increase = 0;

                if (this.upvotes > this.downvotes) {
                    increase = 0.25 * this.upvotes;
                } else {
                    increase = 0.25 * this.downvotes;
                }

                result.push(Math.ceil(this.upvotes + increase));
                result.push(Math.ceil(this.downvotes + increase));
            } else {
                result.push(this.upvotes);
                result.push(this.downvotes);
            }

            result.push(result[0] - result[1]);

            if (this.upvotes + this.downvotes < 10) {
                result.push('new');
            }else if (this.upvotes > this.downvotes && this.upvotes / (this.upvotes + this.downvotes) > 0.66){
                result.push('hot');
            } else if (this.upvotes >= this.downvotes && Math.max(this.upvotes, this.downvotes) > 100) {
                result.push('controversial');
            } else if (this.upvotes < this.downvotes) {
                result.push('unpopular');
            } else  {
                result.push('new');
            }

            return result;
        default:
            break;
    }
}

let answer = solution.call(forumPost, 'score');
console.log(answer);

