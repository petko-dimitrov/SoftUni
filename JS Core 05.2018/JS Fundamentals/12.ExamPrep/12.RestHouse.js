function solve(roomsArr, guestsArr) {
    let rooms = {};
    let doubleRooms = [];
    let tripleRooms = [];
    let spareBeds = {};
    spareBeds['female'] = false;
    spareBeds['male'] = false;
    let teaHouse = 0;

    for (let room of roomsArr) {
        rooms[room.number] = {};

        if (room.type === 'double-bedded') {
            rooms[room.number]['beds'] = 2;
            doubleRooms.push(room.number);
        } else {
            rooms[room.number]['beds'] = 3;
            tripleRooms.push(room.number);
        }
    }

    for (let guest of guestsArr) {
        if (guest.first.gender !== guest.second.gender) {
            if (doubleRooms.length > 0) {
                let room = doubleRooms.shift();
                rooms[room][guest.first.name] = guest.first.age;
                rooms[room][guest.second.name] = guest.second.age;
                rooms[room]['beds'] = 0;
            } else {
                teaHouse += 2;
            }
        }

        else if (guest.first.gender === 'male') {
            if (spareBeds['male'] === false) {
                if (tripleRooms.length > 0) {
                    let room = tripleRooms.shift();
                    rooms[room][guest.first.name] = guest.first.age;
                    rooms[room][guest.second.name] = guest.second.age;
                    rooms[room]['beds'] = 1;
                    spareBeds['male'] = room;
                } else {
                    teaHouse += 2;
                }
            } else {
                if (rooms[spareBeds['male']]['beds'] === 2) {
                    rooms[spareBeds['male']][guest.first.name] = guest.first.age;
                    rooms[spareBeds['male']][guest.second.name] = guest.second.age;
                    rooms[spareBeds['male']]['beds'] = 0;
                    spareBeds['male'] = false;
                }
                else {
                    rooms[spareBeds['male']][guest.first.name] = guest.first.age;
                    rooms[spareBeds['male']]['beds'] = 0;
                    spareBeds['male'] = false;
                    if (tripleRooms.length > 0) {
                        let room = tripleRooms.shift();
                        rooms[room][guest.second.name] = guest.second.age;
                        rooms[room]['beds'] = 2;
                        spareBeds['male'] = room;
                    } else {
                        teaHouse++;
                    }
                }

            }
        }

        else {
            if (spareBeds['female'] === false) {
                if (tripleRooms.length > 0) {
                    let room = tripleRooms.shift();
                    rooms[room][guest.first.name] = guest.first.age;
                    rooms[room][guest.second.name] = guest.second.age;
                    rooms[room]['beds'] = 1;
                    spareBeds['female'] = room;
                } else {
                    teaHouse += 2;
                }
            } else {
                if (rooms[spareBeds['female']]['beds'] === 2) {
                    rooms[spareBeds['female']][guest.first.name] = guest.first.age;
                    rooms[spareBeds['female']][guest.second.name] = guest.second.age;
                    rooms[spareBeds['female']]['beds'] = 0;
                    spareBeds['female'] = false;
                }
                else {
                    rooms[spareBeds['female']][guest.first.name] = guest.first.age;
                    rooms[spareBeds['female']]['beds'] = 0;
                    spareBeds['female'] = false;
                    if (tripleRooms.length > 0) {
                        let room = tripleRooms.shift();
                        rooms[room][guest.second.name] = guest.second.age;
                        rooms[room]['beds'] = 2;
                        spareBeds['female'] = room;
                    } else {
                        teaHouse++;
                    }
                }
            }
        }
    }

    let sortedRooms = Object.keys(rooms).sort();

    for (let sortedRoom of sortedRooms) {
        console.log(`Room number: ${sortedRoom}`);
        let sortedGuests = Object.keys(rooms[sortedRoom]).sort().filter(x => x !== 'beds');

        for (let sortedGuest of sortedGuests) {
            console.log(`--Guest Name: ${sortedGuest}`);
            console.log(`--Guest Age: ${rooms[sortedRoom][sortedGuest]}`);
        }

        console.log(`Empty beds in the room: ${rooms[sortedRoom]['beds']}`);
    }

    console.log(`Guests moved to the tea house: ${teaHouse}`);
}

    solve([ { number: '101A', type: 'double-bedded' },
            { number: '104', type: 'triple' },
            { number: '101B', type: 'double-bedded' },
            { number: '102', type: 'triple' } ],
        [ { first: { name: 'Sushi & Chicken', gender: 'female', age: 15 },
            second: { name: 'Salisa Debelisa', gender: 'female', age: 25 } },
            { first: { name: 'Daenerys Targaryen', gender: 'female', age: 20 },
                second: { name: 'Jeko Snejev', gender: 'male', age: 18 } },
            { first: { name: 'Pesho Goshov', gender: 'male', age: 20 },
                second: { name: 'Gosho Peshov', gender: 'male', age: 18 } },
            { first: { name: 'Conor McGregor', gender: 'male', age: 29 },
                second: { name: 'Floyd Mayweather', gender: 'male', age: 40 } } ]);