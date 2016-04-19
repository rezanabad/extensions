﻿import * as React from 'react'
import { classes } from '../../../../Framework/Signum.React/Scripts/Globals'
import { FormGroup, FormControlStatic, EntityComponent, ValueLine, ValueLineType, EntityLine, EntityCombo, EntityList, EntityRepeater, EntityFrame} from '../../../../Framework/Signum.React/Scripts/Lines'
import {SearchControl }  from '../../../../Framework/Signum.React/Scripts/Search'
import { TypeContext, FormGroupStyle } from '../../../../Framework/Signum.React/Scripts/TypeContext'
import { PackageOperationEntity, PackageLineEntity } from '../Signum.Entities.Processes'

export default class PackageOperation extends EntityComponent<PackageOperationEntity> {

    renderEntity() {
        
        var e = this.props.ctx;

        return (
            <div>
                <ValueLine ctx={e.subCtx(f => f.name)}  />
                <EntityLine ctx={e.subCtx(f => f.operation)} readOnly={true} />
                <fieldset>
                    <legend>{ PackageLineEntity.nicePluralName() }</legend>
                    <SearchControl findOptions={{ queryName: PackageLineEntity, parentColumn: "Package", parentValue : e.value}}  />
                </fieldset>
            </div>
        );
    }
}

