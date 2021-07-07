namespace SereneDemo.Northwind {
    export enum OrderShippingState {
        NotShipped = 0,
        Shipped = 1
    }
    Serenity.Decorators.registerEnumType(OrderShippingState, 'SereneDemo.Northwind.OrderShippingState', 'Northwind.OrderShippingState');
}
