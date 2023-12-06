export class Recipe {
    constructor(data) {
        this.id = data.id
        this.title = data.title
        this.description = data.description
        this.img = data.img
        this.category = data.category
        this.creator = data.creator

    }
}


// const recipe data = {
//     "id": 1,
//     "createdAt": "2023-12-01T19:11:14",
//     "updatedAt": "2023-12-01T23:03:29",
//     "title": "Oat Milk Shoes",
//     "instructions": "Take your seafood and cook it, then add the soup.  Boom, jumbalya. Edited.",
//     "img": "https://images.unsplash.com/photo-1574946943172-4800feadfab7?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=900&q=80",
//     "category": "Specialty Coffee",
//     "creatorId": "652eeda69f8ff255572e269a",
//     "creator": {
//         "id": "652eeda69f8ff255572e269a",
//         "createdAt": "2023-12-01T18:49:03",
//         "updatedAt": "2023-12-01T18:49:03",
//         "name": "cody@gmail.com",
//         "picture": "https://s.gravatar.com/avatar/6f414bef4e1193725cc478ff5ae42c98?s=480&r=pg&d=https%3A%2F%2Fcdn.auth0.com%2Favatars%2Fco.png"
//     }
// }