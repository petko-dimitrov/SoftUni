const Sequelize = require('sequelize');

module.exports = function (sequelize) {
    let Task = sequelize.define("Task", {
        title: {
            type: Sequelize.TEXT,
            allowNull: false
        },
        status: {
            type:Sequelize.ENUM,
            values:["Open",'In Progress', 'Finished']
        }
    }, {
        timestamps: false
    });

    return Task;
};