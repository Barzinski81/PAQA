import { isOddOrEven } from '../isOddOrEven.js';
import { expect } from 'chai';

describe('Is even or odd', () => {

    it('The input is not correct', () => {

        // Arrange
        let input = 23;
        let expected = undefined;

        // Act
        let actual = isOddOrEven(input);

        // Assert
        expect(actual).to.equal(expected);
    });

    it('The input is even', () => {

        // Arrange
        let input = "text";
        let expected = "even";

        // Act
        let actual = isOddOrEven(input);

        // Assert
        expect(actual).to.equal(expected);
    });

    it('The input is odd', () => {

        // Arrange
        let input = "odd";
        let expected = "odd";

        // Act
        let actual = isOddOrEven(input);

        // Assert
        expect(actual).to.equal(expected);
    });

});