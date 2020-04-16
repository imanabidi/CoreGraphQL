﻿namespace Orders.Models
{
    public enum OrderStatuses
    {
        CREATED = 2,
        PROCESSING = 4,
        COMPLETED = 8 , 
        CANCELLED = 16,
        CLOSED = 32
    }
}
