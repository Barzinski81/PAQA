import {foodDelivery} from  '../foodDelivery.js'
import {expect} from 'chai'

describe('Test_foodDelivery', () => {

    describe('Test getCategory', () => {

        it('Correct category', () => {

            expect(foodDelivery.getCategory("Vegan")).to.equal("Dishes that contain no animal products.");
            expect(foodDelivery.getCategory("Vegetarian")).to.equal("Dishes that contain no meat or fish.");
            expect(foodDelivery.getCategory("Gluten-Free")).to.equal("Dishes that contain no gluten.");
            expect(foodDelivery.getCategory("All")).to.equal("All available dishes.");

        });

        it('Incorrect category', () => {

            expect(() => foodDelivery.getCategory(123)).to.throw("Invalid Category!");
            expect(() => foodDelivery.getCategory(null)).to.throw("Invalid Category!");
            expect(() => foodDelivery.getCategory("Nothing")).to.throw("Invalid Category!");
            expect(() => foodDelivery.getCategory([])).to.throw("Invalid Category!");
            expect(() => foodDelivery.getCategory({})).to.throw("Invalid Category!");

        });
    });

    describe('Test addMenuItem', () => {
        
        it('Valid input', () => {

            let input1 = [
                {name: "Food1", price: 10},
                {name: "Food2", price: 20},
                {name: "Food3", price: 30}];

            let number1 = 100;  
            
            let input2 = [
                {name: "Food1", price: 10},
                {name: "Food2", price: 20},
                {name: "Food3", price: 30}];

            let number2 = 20;
            
            expect(foodDelivery.addMenuItem(input1, number1)).to.equal("There are 3 available menu items matching your criteria!");
            expect(foodDelivery.addMenuItem(input2, number2)).to.equal("There are 2 available menu items matching your criteria!");
        
        });

        it('Invalid input', () => {

            expect(() => foodDelivery.addMenuItem(123, 100)).to.throw("Invalid Information!");
            expect(() => foodDelivery.addMenuItem([1, 2, 3], "price")).to.throw("Invalid Information!");
            expect(() => foodDelivery.addMenuItem([1, 2, 3], 2.50)).to.throw("Invalid Information!");
            expect(() => foodDelivery.addMenuItem([], 20)).to.throw("Invalid Information!");

        });
    });

    describe('Test calculateOrderCost', () => { 
        
        it('Correct input', () => {

            expect(foodDelivery.calculateOrderCost(['standard', 'express'], ['sauce', 'beverage'], false))
            .to.equal('You spend $12.50 for shipping and addons!')
            
            expect(foodDelivery.calculateOrderCost(['standard', 'express'], ['sauce', 'beverage'], true))
            .to.equal('You spend $10.63 for shipping and addons with a 15% discount!')
            
        });

        it('Invalid input', () => {

            expect(() => foodDelivery.calculateOrderCost()).to.throw("Invalid Information!");
            expect(() => foodDelivery.calculateOrderCost([1, 2, 3], "price", true)).to.throw("Invalid Information!");
            expect(() => foodDelivery.calculateOrderCost([1, 2, 3], [1, 2, 3], 3.14)).to.throw("Invalid Information!");
            expect(() => foodDelivery.calculateOrderCost(1, [1, 2, 3], false)).to.throw("Invalid Information!");

        });

    });

});        