namespace SereneDemo.Northwind {
    export enum Gender {
        Male = 1,
        Female = 2
    }
    Serenity.Decorators.registerEnumType(Gender, 'SereneDemo.Northwind.Gender', 'SereneDemo.Northwind.Entities.Gender');
}
