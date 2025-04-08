import {artGallery} from '../artGallery.js'
import {expect} from 'chai'

describe('Art gallery', () => {

describe('Test addArtwork', () => {

    it('Valid input', () => {

        let expected = "Artwork added successfully: 'Poppies' by Monet with dimensions 650 x 500."

        expect(artGallery.addArtwork("Poppies", "650 x 500", "Monet")).to.equal(expected);
                      
    });

    it('Invalid title', () => {

        expect(() => artGallery.addArtwork(null, "650 x 500", "Monet")).to.throw("Invalid Information!");
        expect(() => artGallery.addArtwork(undefined, "650 x 500", "Monet")).to.throw("Invalid Information!")
        expect(() => artGallery.addArtwork(50, "650 x 500", "Monet")).to.throw("Invalid Information!")
                      
    });

    it('Invalid dimensions', () => {

        expect(() => artGallery.addArtwork("Poppies", "650x 500", "Monet")).to.throw("Invalid Dimensions!");
        expect(() => artGallery.addArtwork("Poppies", "650x500", "Monet")).to.throw("Invalid Dimensions!")
        expect(() => artGallery.addArtwork("Poppies", null, "Monet")).to.throw("Invalid Dimensions!")
        expect(() => artGallery.addArtwork("Poppies", "650 x500", "Monet")).to.throw("Invalid Dimensions!")
                      
    });

    it('Invalid artist', () => {

        expect(() => artGallery.addArtwork("Poppies", "650 x 500", "Dali")).to.throw("This artist is not allowed in the gallery!");
                            
    });

});

describe('Test calculateCosts', () => {

    it('Valid input', () => {

        expect(artGallery.calculateCosts(1000, 100, false)).to.equal("Exhibition and insurance costs are 1100$.")
        expect(artGallery.calculateCosts(1000, 100, true)).to.equal("Exhibition and insurance costs are 990$, reduced by 10% with the help of a donation from your sponsor.")
    });
    
    it('Invalid input', () => {
    
        expect(() => artGallery.calculateCosts()).to.throw("Invalid Information!")
        expect(() => artGallery.calculateCosts("costs", 100, true)).to.throw("Invalid Information!")
        expect(() => artGallery.calculateCosts(100, "costs", true)).to.throw("Invalid Information!")
        expect(() => artGallery.calculateCosts(500, 100, 50)).to.throw("Invalid Information!")
        expect(() => artGallery.calculateCosts(-500, 100, true)).to.throw("Invalid Information!")
        expect(() => artGallery.calculateCosts("costs", -100, true)).to.throw("Invalid Information!")
    });
});

describe('Test organizeExhibits', () => { 

    it('Valid input', () => {
            expect(artGallery.organizeExhibits(80, 20)).to.equal("There are only 4 artworks in each display space, you can add more artworks.") 
            expect(artGallery.organizeExhibits(100, 20)).to.equal("You have 20 display spaces with 5 artworks in each space.")
    });

    it('Invalid input', () => {
            expect(() => artGallery.organizeExhibits("count", 20)).to.throw("Invalid Information!")
            expect(() => artGallery.organizeExhibits(10, "spaces")).to.throw("Invalid Information!")
            expect(() => artGallery.organizeExhibits(-10, 20)).to.throw("Invalid Information!")    
            expect(() => artGallery.organizeExhibits(10, -20)).to.throw("Invalid Information!")
    });

});

});