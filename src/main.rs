fn main() {
    println!("Hello, world!");
}

struct Individual {
    age: u32,
    salary: u32
}

struct Family {
    units: Individual,
}

struct Business {

}

struct Policy {

}

struct Government {

}

impl Individual {
    fn new(age: u32, salary: u32) -> Individual {
        Individual { age, salary }
    }

    fn pay_taxes() -> void {

    }

    fn pay_business() -> void {

    }
}

impl Business {
    fn new() -> Business {
        Business { }
    }

    fn pay_employees() -> void {

    }
}

impl Government {
    fn new() -> Government {
        Government {}
    }
}

impl Policy {
    fn new() -> Policy {
        Policy {}
    }
}