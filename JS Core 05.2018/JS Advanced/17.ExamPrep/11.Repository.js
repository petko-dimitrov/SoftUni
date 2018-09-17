class Repository {
    constructor(props) {
        this.props = props;
        this.data = new Map();
        this.id = 0;
    }

    add(entity) {
        for (const key of Object.keys(entity)) {
            if (!this.props.hasOwnProperty(key)) {
                throw new TypeError(`Property ${key} is missing from the entity!`)
            }
            if (typeof entity[key] !== this.props[key]) {
                throw new TypeError ('Property ' + key + ' is of incorrect type!')
            }
        }

        this.data.set(this.id, entity);
        this.id++;
        return this.id - 1;
    }

    get(id) {
        let arr = Array.from(this.data.values());
        if (arr[id] === undefined) {
            throw new Error (`Entity with id: ${id} does not exist!`);
        }
        return arr[id];
    }

    update(id, newEntity) {
        if (this.get(id) === undefined) {
            throw new Error (`Entity with id: ${id} does not exist!`);
        }

        for (const key of Object.keys(newEntity)) {
            if (!this.props.hasOwnProperty(key)) {
                throw new TypeError(`Property ${key} is missing from the entity!`)
            }
            if (typeof newEntity[key] !== this.props[key]) {
                throw new TypeError ('Property ' + key + ' is of incorrect type!')
            }
        }

        this.data.set(id, newEntity);
    }

    del(id) {
        if (this.get(id) === undefined) {
            throw new Error (`Entity with id: ${id} does not exist!`);
        }

        this.data.delete(id);
    }

    get count() {
        return this.data.size;
    }
}

let properties = {
    name: "string",
    age: "number",
    birthday: "object"
};
//Initialize the repository
let repository = new Repository(properties);
// Add two entities
let entity = {
    name: "Kiril",
    age: 19,
    birthday: new Date(1998, 0, 7)
};
repository.add(entity); // Returns 0
console.log(repository.get(1));