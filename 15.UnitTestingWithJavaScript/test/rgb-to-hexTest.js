import { expect } from 'chai';
import { describe } from 'mocha';
import { rgbToHexColor } from '../rgb-to-hex.js';

describe('RGB to hex color converter', () => {

    it('valid rgb input', () => {
        // Arrange
        let red = 22;
        let green = 45;
        let blue = 75;
        let expected = "#162D4B";

        // Act
        let actual = rgbToHexColor(red, green, blue);

        // Assert
        expect(actual).to.equal(expected);

    });

    it('valid rgb input max values', () => {
        // Arrange
        let red = 255;
        let green = 255;
        let blue = 255;
        let expected = "#FFFFFF";

        // Act
        let actual = rgbToHexColor(red, green, blue);

        // Assert
        expect(actual).to.equal(expected);

    });

    it('valid rgb input min values', () => {
        // Arrange
        let red = 0;
        let green = 0;
        let blue = 0;
        let expected = "#000000";

        // Act
        let actual = rgbToHexColor(red, green, blue);

        // Assert
        expect(actual).to.equal(expected);

    });

    it('invalid red rgb input range', () => {
        // Arrange
        let red = 422;
        let green = 45;
        let blue = 75;
        let expected = undefined;

        // Act
        let actual = rgbToHexColor(red, green, blue);

        // Assert
        expect(actual).to.equal(expected);

    });

    it('invalid green rgb input range', () => {
        // Arrange
        let red = 22;
        let green = -45;
        let blue = 75;
        let expected = undefined;

        // Act
        let actual = rgbToHexColor(red, green, blue);

        // Assert
        expect(actual).to.equal(expected);

    });

    it('invalid blue rgb input range', () => {
        // Arrange
        let red = 22;
        let green = 45;
        let blue = 260;
        let expected = undefined;

        // Act
        let actual = rgbToHexColor(red, green, blue);

        // Assert
        expect(actual).to.equal(expected);

    });

    it('invalid red rgb input type', () => {
        // Arrange
        let red = "red"
        let green = 45;
        let blue = 75;
        let expected = undefined;

        // Act
        let actual = rgbToHexColor(red, green, blue);

        // Assert
        expect(actual).to.equal(expected);

    });

    it('invalid green rgb input type', () => {
        // Arrange
        let red = 22;
        let green = "color";
        let blue = 75;
        let expected = undefined;

        // Act
        let actual = rgbToHexColor(red, green, blue);

        // Assert
        expect(actual).to.equal(expected);

    });

    it('invalid blue rgb input type', () => {
        // Arrange
        let red = 22;
        let green = 45;
        let blue = 5.5;
        let expected = undefined;

        // Act
        let actual = rgbToHexColor(red, green, blue);

        // Assert
        expect(actual).to.equal(expected);

    });

    it('null rgb input type', () => {
        // Arrange
        let red = 22;
        let green = 45;
        let blue = undefined;
        let expected = undefined;

        // Act
        let actual = rgbToHexColor(red, green, blue);

        // Assert
        expect(actual).to.equal(expected);

    });
  
});