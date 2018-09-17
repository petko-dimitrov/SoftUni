function solve() {
    class Post {
        constructor(title, content){
            this.title = title;
            this.content = content;
        }

        toString() {
            return `Post: ${this.title}\nContent: ${this.content}`;
        }
    }

    class SocialMediaPost extends Post {
        constructor(title, content, likes, dislikes) {
            super(title, content);
            this.likes = likes;
            this.dislikes = dislikes;
            this.comments = [];
        }

        addComment(comment) {
            this.comments.push(comment);
        }

        toString() {
            let rating = this.likes - this.dislikes;
            let result = super.toString() + `\nRating: ${rating}\n`;
            if (this.comments.length > 0) {
                result += 'Comments:\n';
                for (const comment of this.comments) {
                    result += ` * ${comment}\n`;
                }
            }
            return result.trim();
        }
    }

    class BlogPost extends Post {
        constructor(title, content, views) {
            super(title, content);
            this.views = views;
        }

        view() {
            this.views++;
            return this;
        }

        toString(){
            return super.toString() + `\nViews: ${this.views}`;
        }
    }

    return {Post, SocialMediaPost, BlogPost};
 }