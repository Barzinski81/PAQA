import { expect } from 'chai';
import { describe } from 'mocha';
import { createCalculator } from '../addSubtract.js';

describe('createCalculator', () => {

    it('add positive number', () => {

        // Arrange  
        let calc = createCalculator();
        let number = 5;

        // Act
        calc.add(number);

        // Assert
        expect(calc.get()).to.equal(5);

    });

    it('add negative number', () => {

        // Arrange  
        let calc = createCalculator();
        let number = -5;

        // Act
        calc.add(number);

        // Assert
        expect(calc.get()).to.equal(-5);

    });

    it('add zero', () => {

        // Arrange  
        let calc = createCalculator();
        let number = 0;

        // Act
        calc.add(number);

        // Assert
        expect(calc.get()).to.equal(0);

    });

    it('subtract positive number', () => {

        // Arrange  
        let calc = createCalculator();
        let number = 5;

        // Act
        calc.subtract(number);

        // Assert
        expect(calc.get()).to.equal(-5);

    });

    it('subtract negative number', () => {

        // Arrange  
        let calc = createCalculator();
        let number = -5;

        // Act
        calc.subtract(number);

        // Assert
        expect(calc.get()).to.equal(5);

    });

    it('subtract zero', () => {

        // Arrange  
        let calc = createCalculator();
        let number = 0;

        // Act
        calc.subtract(number);

        // Assert
        expect(calc.get()).to.equal(0);

    });

    it('add number as text', () => {

        // Arrange  
        let calc = createCalculator();
        let number = '10';

        // Act
        calc.add(number);

        // Assert
        expect(calc.get()).to.equal(10);

    });

    it('subtract number as text', () => {

        // Arrange  
        let calc = createCalculator();
        let number = '10';

        // Act
        calc.subtract(number);

        // Assert
        expect(calc.get()).to.equal(-10);

    });

    it('add text', () => {

        // Arrange  
        let calc = createCalculator();
        let number = 'text';

        // Act
        calc.add(number);

        // Assert
        expect(calc.get()).to.be.NaN;

    });

});

